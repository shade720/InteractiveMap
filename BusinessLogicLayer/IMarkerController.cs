using GMap.NET.WindowsForms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InteractiveMap.BusinessLogicLayer
{
    public interface IMarkerController
    {
        IEnumerable<GMapMarker> GetAllSavedMarkers();
        Task<IEnumerable<GMapMarker>> GetAllSavedMarkersAsync();
        void ChangeMarker(GMapMarker newMarker);
        Task ChangeMarkerAsync(GMapMarker newMarker);
    }
}
