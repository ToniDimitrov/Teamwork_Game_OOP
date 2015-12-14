using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interfaces
{
    internal interface IItem
    {
        int AttackEffect { get; set; }
        int DefenceEffect { get; set; }
        int HealthEffect { get; set; }
    }
}
