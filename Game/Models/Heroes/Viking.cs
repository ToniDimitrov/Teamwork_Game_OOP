using System.Collections.Generic;
using Game.Models;

namespace Game.Models.Heroes
{
    public class Viking : Hero
    {
        private const int vikingHealth = 120;
        private const int vikingAttack = 30;
        private const int vikingDefence = 18;
        private const string pathToImage = "Viking.png";

        protected Viking(string id, Point location, Size objectSize, List<Item> items) 
            : base(id, location, objectSize, vikingHealth, vikingAttack, vikingDefence, items, pathToImage)
        {
        }
    }
}