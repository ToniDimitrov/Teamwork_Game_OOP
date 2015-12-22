using System.Collections.Generic;
using System.Windows.Forms;

namespace Game.Interfaces
{
    public interface IHero : IAttack, IDefence, IDestroyable, IGameObject
    {
        PictureBox HeroImage { get; set; }
        PictureBox HeroImage1 { get; set; }
        PictureBox HeroImage2 { get; set; }
        PictureBox HeroImage3 { get; set; }
        IList<IItem> Items { get; set; }
        bool IsAlive { get; set; }

        void Attack(IHero enemy);
    }
}