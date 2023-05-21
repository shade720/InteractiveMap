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
        private readonly DbAccess _db;
        public GoogleMarkerController(DbAccess db)
        {
            _db = db;
        }

        public async Task<IEnumerable<GMapMarker>> GetAllSavedMarkersAsync()
        {
            return (await _db.GetMarkers()).Select(m =>
            {
                var googleMarker = new GMarkerGoogle(new PointLatLng(m.Latitude, m.Longitude), (GMarkerGoogleType)m.ColorNum);
                googleMarker.ToolTip = new GMapRoundedToolTip(googleMarker);
                googleMarker.ToolTipText = $"{m.Name}\r\n{m.Description}";
                googleMarker.ToolTipMode = MarkerTooltipMode.Always;
                googleMarker.Tag = m.Id;
                return googleMarker;
            });
        }

        public async Task ChangeMarkerAsync(GMapMarker newMarker)
        {
            var nameAndDescription = newMarker.ToolTipText.Split('\n');
            await _db.UpdateMarker(new MarkerInfo
            {
                Id = (int)newMarker.Tag,
                Name = nameAndDescription[0],
                Description = nameAndDescription[1],
                Latitude = newMarker.Position.Lat,
                Longitude = newMarker.Position.Lng,
                ColorNum = (int)((GMarkerGoogle)newMarker).Type
            });
        }

        public void ChangeMarker(GMapMarker newMarker)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<GMapMarker> GetAllSavedMarkers()
        {
            throw new System.NotImplementedException();
        }
    }
}
