using System.Collections.Generic;
using Game.Models;

namespace ConsoleApplication5.Interfaces
{
    public interface ICollect
    {
        void AddItem(Item item);
        void RemoveItem(Item item);
    }
}