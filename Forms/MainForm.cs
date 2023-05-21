using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using InteractiveMap.BusinessLogicLayer;
using InteractiveMap.DataAccessLayer;

namespace InteractiveMap.Forms
{
    public partial class MainForm : Form
    {
        
        private readonly IMarkerController _markerController;

        public MainForm(IMarkerController markerController, MapState mapState)
        {
            _markerController = markerController;
            InitializeComponent();
            InitializeMap(mapState);
        }

        #region MapInitializing

        private const int MapViewMinZoom = 2;
        private const int MapViewMaxZoom = 16;

        private async void InitializeMap(MapState mapState)
        {
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            MapView.MapProvider = mapState.MapProvider;
            MapView.MinZoom = MapViewMinZoom;
            MapView.MaxZoom = MapViewMaxZoom;
            MapView.Zoom = mapState.Zoom;
            MapView.Position = new PointLatLng(mapState.Latitude, mapState.Longitude);
            MapView.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            MapView.CanDragMap = true;
            MapView.DragButton = MouseButtons.Left;
            MapView.ShowCenter = false;
            MapView.ShowTileGridLines = false;
            var markersOverlay = await GetMarkersOverlay();
            MapView.Overlays.Add(markersOverlay);
        }

        private async Task<GMapOverlay> GetMarkersOverlay()
        {
            var markersOverlay = new GMapOverlay("Markers");
            try
            {
                var savedMarkers = await _markerController.GetAllSavedMarkersAsync();
                foreach (var marker in savedMarkers)
                {
                    markersOverlay.Markers.Add(marker);
                }
                MapView.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return markersOverlay;
        }

        #endregion

        #region CurrentPositionPanel

        private void MapView_MouseMove(object sender, MouseEventArgs e)
        {
            CursorLatitude.Text = MapView.FromLocalToLatLng(e.X, e.Y).Lat.ToString(CultureInfo.InvariantCulture);
            CursorLongitude.Text = MapView.FromLocalToLatLng(e.X, e.Y).Lng.ToString(CultureInfo.InvariantCulture);
        }

        #endregion

        #region MarkerDragNDrop

        private GMarkerGoogle _currentDraggableMarker;

        private void MapView_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentDraggableMarker is null) return;
            HideDraggableMarker();
            MapView.CanDragMap = false;
        }

        private async void MapView_MouseUp(object sender, MouseEventArgs e)
        {
            if (_currentDraggableMarker is null) return;
            var newPosition = MapView.FromLocalToLatLng(e.X, e.Y);

            var dialogResult = MessageBox.Show(
                $"Перенести маркер на:\r\nLat: {newPosition.Lat} Lng: {newPosition.Lng}?",
                @"Перенос",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var newMarkerReplacement = MoveMarker(MapView.Overlays[0], _currentDraggableMarker, newPosition);
                await _markerController.ChangeMarkerAsync(newMarkerReplacement);
            }
            else
            {
                ShowDraggableMarker();
            }
            MapView.CanDragMap = true;
            _currentDraggableMarker = null;
        }

        private static GMapMarker MoveMarker(GMapOverlay markersOverlay, GMarkerGoogle marker, PointLatLng newPosition)
        {
            var newMarker = new GMarkerGoogle(newPosition, marker.Type);
            newMarker.ToolTip = new GMapToolTip(newMarker);
            newMarker.ToolTipText = marker.ToolTipText;
            newMarker.ToolTipMode = MarkerTooltipMode.Always;
            newMarker.Tag = marker.Tag;
            markersOverlay.Markers.Remove(marker);
            markersOverlay.Markers.Add(newMarker);
            return newMarker;
        }

        private void HideDraggableMarker()
        {
            _currentDraggableMarker.IsVisible = false;
            _currentDraggableMarker.ToolTipMode = MarkerTooltipMode.Never;
        }

        private void ShowDraggableMarker()
        {
            _currentDraggableMarker.IsVisible = true;
            _currentDraggableMarker.ToolTipMode = MarkerTooltipMode.Always;
        }

        private void MapView_OnMarkerEnter(GMapMarker item)
        {
            _currentDraggableMarker = (GMarkerGoogle)item;
        }

        private void MapView_OnMarkerLeave(GMapMarker item)
        {
            _currentDraggableMarker = null;
        }

        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.SaveMapState(MapView.Zoom, MapView.Position.Lat, MapView.Position.Lng);
        }
    }
}
