using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Interfaces
{
    public interface ITown : IGameObject
    {
        IHero EnemyHero { get; set; }

        bool IsConquered { get; set; }
        PictureBox PictureTown { get; set; }
    }
}
