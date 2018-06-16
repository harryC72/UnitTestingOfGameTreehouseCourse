using System;
using System.Linq;

namespace TreehouseDefense
{
    public class Path
    {
        private MapLocation[] _path;

        public Path(MapLocation[] pathLocation)
        {
            this._path = pathLocation;
        }

        public bool IsOnPath(MapLocation mapLocation) => _path.Contains(mapLocation);
        
    }

        
}