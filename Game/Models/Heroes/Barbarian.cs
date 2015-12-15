using System.Collections.Generic;

namespace Game.Models.Heroes
{
    public class Barbarian : Hero
    {
        private const int barbarianHealth = 125;
        private const int barbarianAttack = 30;
        private const int barbarianDefence = 25;
        private const string pathImage = "Barbarian.png";

        protected Barbarian(string id, Point location, Size objectSize, List<Item> items) :
            base(id, location, objectSize, barbarianHealth, barbarianAttack, barbarianDefence, items, pathImage)
        {
        }
    }
}