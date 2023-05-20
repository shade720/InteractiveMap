using System;
using System.Windows.Forms;
using InteractiveMap.BusinessLogicLayer;

namespace InteractiveMap.Forms
{
    public partial class MainForm : Form
    {
        private readonly IMarkerController _markerController;

        public MainForm(IMarkerController markerController)
        {
            _markerController = markerController;
            InitializeComponent();
            InitializeMap();
            HeightBar.Value = 4;
        }

        private void InitializeMap()
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            MapView.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            MapView.MinZoom = 2;
            MapView.MaxZoom = 16;
            MapView.Zoom = 4;
            MapView.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);
            MapView.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            MapView.CanDragMap = true;
            MapView.DragButton = MouseButtons.Left;
            MapView.ShowCenter = false;
            MapView.ShowTileGridLines = false;
            foreach (var marker in _markerController.GetAllSavedMarkers())
            {
                MapView.Overlays[0].Markers.Add(marker);
            }
        }

        private void HeightBar_Scroll(object sender, EventArgs e)
        {
            MapView.Zoom = HeightBar.Value;
        }
    }
}
