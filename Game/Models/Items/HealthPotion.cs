using Game.Models;

namespace Game.Models.Items
{
    internal class HealthPotion : Item
    {
        private const int healthPotionAttackEffect = 0;
        private const int healthPotionDefenceEffect = 0;
        private const int healthPotionHealthEffect = 40;
        private const string PathToImage = "../../Resources/Max_health_potion.png";
        
        public HealthPotion(string id, Point location, Size objectSize)
            : base(id, location, objectSize, healthPotionAttackEffect, healthPotionDefenceEffect,
                healthPotionHealthEffect,PathToImage)
        {
        }
    }
}