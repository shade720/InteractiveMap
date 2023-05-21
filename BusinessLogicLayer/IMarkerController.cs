using GMap.NET.WindowsForms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InteractiveMap.BusinessLogicLayer
{
    public interface IMarkerController
    {
        IEnumerable<GMapMarker> GetAllSavedMarkers();
        Task<IEnumerable<GMapMarker>> GetAllSavedMarkersAsync();
        IEnumerable<GMapMarker> ChangeMarker(int id);
        Task<IEnumerable<GMapMarker>> ChangeMarkerAsync(int id);
    }
}
