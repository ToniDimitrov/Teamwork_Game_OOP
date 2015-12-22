using System.Collections.Generic;
using Game.Models;

namespace Game.Interfaces
{
    public interface ICollect
    {
        void AddItem(IItem item);
        void RemoveItem(Item item);
    }
}