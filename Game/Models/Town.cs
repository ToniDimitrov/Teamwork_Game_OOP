using System.Collections.Generic;
using Game.Models;

namespace Game.Models
{
    public class Town : GameObject
    {
        public List<Building> BuildingsInTown { get; set; }

        public Town(string id, Point location, Size objectSize, List<Building> buildingsInTown)
            : base(id, location, objectSize)
        {
            this.BuildingsInTown = buildingsInTown;
        }
    }
}