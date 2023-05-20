using System;
using System.Windows.Forms;
using InteractiveMap.BusinessLogicLayer;
using InteractiveMap.Forms;

namespace InteractiveMap
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var markerController = new GoogleMarkerController();
            Application.Run(new MainForm(markerController));
        }
    }
}
