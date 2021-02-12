using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace drawRoute
{
    class Location
    {
        public int plateCode;
        public int realDistance;
        public int heuristicDistance;
        public int calculatedDistance;
        public Location previousCity;

        public Location(int startpoint)
        {
            this.plateCode = startpoint;
            this.realDistance = 0;
            this.heuristicDistance = 0;
            this.calculatedDistance = 0;
            this.previousCity = null;
        }

        public Location(int plateCode, int realDistance, int heuristicDistance, int calculatedDistance, Location previousCiy)
        {
            this.plateCode = plateCode;
            this.realDistance = realDistance;
            this.heuristicDistance = heuristicDistance;
            this.calculatedDistance = calculatedDistance;
            this.previousCity = previousCiy;
        }
    }
}
