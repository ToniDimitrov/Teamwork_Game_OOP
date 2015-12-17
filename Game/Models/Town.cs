using System.Collections.Generic;
using Game.Interfaces;
using Game.Models;

namespace Game.Models
{
    public class Town : GameObject
    {

        public Town(string id, Point location, Size objectSize, IHero enemyHero, bool isConquered)
            : base(id, location, objectSize)
        {
            this.EnemyHero = enemyHero;
            this.IsConquered = isConquered;
        }

        public IHero EnemyHero { get; set; }

        public bool IsConquered { get; set; }
    }
}