using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms.ToolTips;
using InteractiveMap.DataAccessLayer;

namespace InteractiveMap.BusinessLogicLayer
{
    public class GoogleMarkerController : IMarkerController
    {
        private readonly DatabaseAccess _database;

        public GoogleMarkerController(DatabaseAccess database)
        {
            _database = database;
        }
        public async Task<IEnumerable<GMapMarker>> GetAllSavedMarkersAsync()
        {
            return (await _database.GetMarkers()).Select(m =>
            {
                var googleMarker = new GMarkerGoogle(new PointLatLng(m.Latitude, m.Longitude), (GMarkerGoogleType)m.ColorNum);
                googleMarker.ToolTip = new GMapRoundedToolTip(googleMarker);
                googleMarker.ToolTipText = m.Name;
                googleMarker.ToolTipMode = MarkerTooltipMode.Always;
                return googleMarker;
            });
        }
        
        public IEnumerable<GMapMarker> ChangeMarker(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GMapMarker> GetAllSavedMarkers()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<GMapMarker>> ChangeMarkerAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
