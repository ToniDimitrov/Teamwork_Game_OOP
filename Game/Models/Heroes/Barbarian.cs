using System.Collections.Generic;
using Game.Interfaces;

namespace Game.Models.Heroes
{
    public class Barbarian : Hero
    {
        private const int barbarianAttack = 30;
        private const int barbarianDefence = 25;
        private const int barbarianHealth = 125;
        private const string pathToImage = "Barbarian.png";
        private const string pathToImage1 = "barbarian1.png";
        private const string pathToImage2 = "barbarian2.png";
        private const string pathToImage3 = "barbarian3.png";

        public Barbarian(string id, Point location, Size objectSize, List<Item> items) :
            base(id, location, objectSize, barbarianHealth, barbarianAttack, barbarianDefence, items, pathToImage, pathToImage1, pathToImage2, pathToImage3)
        {
        }
    }
}