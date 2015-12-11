using System.Collections.Generic;
using Game.Models;

namespace Game.Models.Heroes
{
    public class Barbarian : Hero
    {
        private const int barbarianHealth = 125;
        private const int barbarianAttack = 30;
        private const int barbarianDefence = 25;

        protected Barbarian(string id, Point location, Size objectSize, List<Item> items) :
            base(id, location, objectSize, barbarianHealth, barbarianAttack, barbarianDefence, items)
        {
        }
    }
}