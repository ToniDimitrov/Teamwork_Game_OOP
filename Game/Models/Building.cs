using System.Collections.Generic;
using ConsoleApplication5.Models;

namespace Game.Models
{
    public abstract class Building : GameObject
    {
        public List<Item> ItemsInBuilding { get; private set; }

        protected Building(string id, Point location, Size objectSize, List<Item> itemsInBuilding)
            : base(id, location, objectSize)
        {
        
            this.ItemsInBuilding = itemsInBuilding;
        }
    }
}