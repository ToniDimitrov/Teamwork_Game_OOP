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

        public Barbarian(string id, Point location, Size objectSize, List<Item> items) :
            base(id, location, objectSize, barbarianHealth, barbarianAttack, barbarianDefence, items, pathToImage)
        {
        }
    }
}