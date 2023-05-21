using InteractiveMap.BusinessLogicLayer;
using InteractiveMap.DataAccessLayer;
using InteractiveMap.Forms;
using System;
using System.Windows.Forms;

namespace InteractiveMap
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var database = new DbAccess(Properties.Settings.Default.ConnectionString);
            var markerController = new GoogleMarkerController(database);
            var mapState = new MapState
            {
                Zoom = Properties.Settings.Default.Zoom,
                Latitude = Properties.Settings.Default.Latitude,
                Longitude = Properties.Settings.Default.Longitude,
                MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
            };

            Application.Run(new MainForm(markerController, mapState));
        }

        public static void SaveMapState(double zoom, double latitude, double longitude)
        {
            Properties.Settings.Default.Zoom = zoom;
            Properties.Settings.Default.Latitude = latitude;
            Properties.Settings.Default.Longitude = longitude;
            Properties.Settings.Default.Save();
        }
    }
}
