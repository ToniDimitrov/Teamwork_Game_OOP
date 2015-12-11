using Game.Models;

namespace ConsoleApplication5.Models.Items
{
    internal class HealthPotion : Item
    {
        private const int healthPotionAttackEffect = 0;
        private const int healthPotionDefenceEffect = 0;
        private const int healthPotionHealthEffect = 40;

        public HealthPotion(string id, Point location, Size objectSize)
            : base(
                id, location, objectSize, healthPotionAttackEffect, healthPotionDefenceEffect,
                healthPotionHealthEffect)
        {
        }
    }
}