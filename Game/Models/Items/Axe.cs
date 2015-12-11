using Game.Models;

namespace Game.Models.Items
{
    public class Axe : Item
    {
        private const int AxeAttackEffect = 25;
        private const int AxeDefenceEffect = 5;
        private const int AxeHealthEffect = 0;

        public Axe(string id, Point location, Size objectSize)
            : base(id, location, objectSize, AxeAttackEffect, AxeDefenceEffect, AxeHealthEffect)
        {
        }
    }
}