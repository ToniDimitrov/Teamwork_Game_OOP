using Game.Models;

namespace Game.Models.Items
{
    public class Shield : Item
    {
        private const int shieldAttackEffect = 5;
        private const int shieldDefenceEffect = 25;
        private const int shieldHealthEffect = 0;
        private const string PathToImage = "../../Resources/hylian_shield.png";
        
        public Shield(string id, Point location, Size objectSize)
            : base(id, location, objectSize, shieldAttackEffect, shieldDefenceEffect, shieldHealthEffect,PathToImage)
        {
        }
    }
}