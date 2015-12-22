using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Models;

namespace Game.Interfaces
{
    public interface IPlayer: IHero,ICollect,IMove
    {
        Point NextStep(Point direction);
        PlayerRace Race { get; set; }
    }
}
