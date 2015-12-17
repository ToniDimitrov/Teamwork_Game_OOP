using System.Collections.Generic;
using Game.Interfaces;

namespace Game.Models.Heroes
{
    public class Spartan : Hero
    {
        private const int spartanHealth = 110;
        private const int spartanAttack = 25;
        private const int spartanDefence = 35;
        private const string pathToImage = "Spartan.png";

        public Spartan(string id, Point location, Size objectSize, List<Item> items)
            : base(id, location, objectSize, spartanHealth, spartanAttack, spartanDefence, items, pathToImage)
        {
        }
    }
}