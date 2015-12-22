using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Models;

namespace Game.Interfaces
{
    public interface IGameObject
    {
        Point Location { get; set; }

        Size ObjectSize { get; set; }
        string Id { get; }
    }
}
