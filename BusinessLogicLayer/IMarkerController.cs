using GMap.NET.WindowsForms;
using System.Collections.Generic;

namespace InteractiveMap.BusinessLogicLayer
{
    public interface IMarkerController
    {
        IEnumerable<GMapMarker> GetAllSavedMarkers();
        IEnumerable<GMapMarker> ChangeMarker(int id);
    }
}
