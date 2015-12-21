using System.Collections.Generic;
using Game.Interfaces;

namespace Game.Models.Heroes
{
    public class Viking : Hero
    {
        private const int vikingHealth = 120;
        private const int vikingAttack = 30;
        private const int vikingDefence = 18;
        private const string pathToImage = "Viking.png";
        private const string pathToImage1 = "Viking1.png";
        private const string pathToImage2 = "Viking2.png";
        private const string pathToImage3 = "Viking3.png";

        public Viking(string id, Point location, Size objectSize, List<Item> items)
            : base(id, location, objectSize, vikingHealth, vikingAttack, vikingDefence, items, pathToImage, pathToImage1, pathToImage2, pathToImage3)
        {
        }
    }
}