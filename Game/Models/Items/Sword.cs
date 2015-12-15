namespace Game.Models.Items
{
    public class Sword : Item
    {
        private const int swordAttackEffect = 20;
        private const int swordDefenceEffect = 10;
        private const int swordHealthEffect = 0;
        private const string PathImage = "../../Resources/Dream_Sword.png";

        public Sword(string id, Point location, Size objectSize)
            : base(id, location, objectSize, swordAttackEffect, swordDefenceEffect, swordHealthEffect,PathImage)
        {
        }
    }
}