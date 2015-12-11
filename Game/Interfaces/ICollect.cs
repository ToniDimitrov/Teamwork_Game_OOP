using System.Collections.Generic;
using Game.Models;

namespace Game.Interfaces
{
    public interface ICollect
    {
        void AddItem(Item item);
        void RemoveItem(Item item);
    }
}