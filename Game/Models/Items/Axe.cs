using Game.Models;

namespace Game.Models.Items
{
    public class Axe : Item
    {
        private const int AxeAttackEffect = 25;
        private const int AxeDefenceEffect = 5;
        private const int AxeHealthEffect = 0;
        private const string PathToImage = "../../Resources/Vampire_One-Handed_Axe33x33.png";

        public Axe(string id, Point location, Size objectSize)
            : base(id, location, objectSize, AxeAttackEffect, AxeDefenceEffect, AxeHealthEffect, PathToImage)
        {
        }
    }
}