using System.Windows.Forms;

namespace Game.Interfaces
{
    public interface IItem : IGameObject
    {
        int AttackEffect { get; set; }
        int DefenceEffect { get; set; }
        int HealthEffect { get; set; }
        PictureBox ItemImage { get; set; }
    }
}
