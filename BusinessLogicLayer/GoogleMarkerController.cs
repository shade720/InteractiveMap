using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;

namespace InteractiveMap.BusinessLogicLayer
{
    public class GoogleMarkerController : IMarkerController
    {
        public IEnumerable<GMapMarker> GetAllSavedMarkers()
        {
            return new List<GMarkerGoogle>();
        }

        public IEnumerable<GMapMarker> ChangeMarker(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
