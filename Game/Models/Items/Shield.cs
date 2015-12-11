using ConsoleApplication5.Models;

namespace Game.Models.Items
{
    public class Shield : Item
    {
        private const int shieldAttackEffect = 5;
        private const int shieldDefenceEffect = 25;
        private const int shieldHealthEffect = 0;

        public Shield(string id, Point location, Size objectSize)
            : base(id, location, objectSize, shieldAttackEffect, shieldDefenceEffect, shieldHealthEffect)
        {
        }
    }
}