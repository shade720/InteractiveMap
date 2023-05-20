using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InteractiveMap.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
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
        }

        private void HeightBar_Scroll(object sender, EventArgs e)
        {
            MapView.Zoom = HeightBar.Value;
        }
    }
}
