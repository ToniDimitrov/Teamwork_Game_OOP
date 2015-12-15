using Game.Models;

namespace Game.Models.Items
{
    internal class Spear : Item
    {
        private const int spearAttackEffect = 15;
        private const int spearDefenceEffect = 4;
        private const int spearHealthEffect = 0;
        private const string PathImage = "../../Resources/Sol_Spear.png";
        
        public Spear(string id, Point location, Size objectSize)
            : base(id, location, objectSize, spearAttackEffect, spearDefenceEffect, spearHealthEffect,PathImage)
        {
        }
    }
}