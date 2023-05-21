using System;
using System.Drawing;
using System.Reflection;
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

        private async void InitializeMap(MapState mapState)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            MapView.MapProvider = mapState.MapProvider;
            MapView.MinZoom = 2;
            MapView.MaxZoom = 16;
            MapView.Zoom = mapState.Zoom;
            MapView.Position = new GMap.NET.PointLatLng(mapState.Latitude, mapState.Longitude);
            MapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return markersOverlay;
        }

        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.SaveMapState(MapView.Zoom, MapView.Position.Lat, MapView.Position.Lng);
        }
    }
}
