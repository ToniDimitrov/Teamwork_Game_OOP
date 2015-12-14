using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Models;

namespace Game.Interfaces
{
    interface IMove
    {
        void Move(Point destination);
    }
}
