using System.Collections.Generic;
using Game.Models;

namespace Game.Models
{
    public class Town : GameObject
    {
        public Town(string id, Point location, Size objectSize, List<Building> buildingsInTown, bool isConquered)
            : base(id, location, objectSize)
        {
            this.BuildingsInTown = buildingsInTown;
            this.IsConquered = isConquered;

        }

        public List<Building> BuildingsInTown { get; set; }

        public bool IsConquered { get; set; }
    }
}