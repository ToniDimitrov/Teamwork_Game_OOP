using Game.Models;

namespace Game.Models.Items
{
    internal class Spear : Item
    {
        private const int spearAttackEffect = 15;
        private const int spearDefenceEffect = 4;
        private const int spearHealthEffect = 0;

        public Spear(string id, Point location, Size objectSize)
            : base(id, location, objectSize, spearAttackEffect, spearDefenceEffect, spearHealthEffect)
        {
        }
    }
}