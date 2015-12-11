using System.Collections.Generic;
using Game.Interfaces;

namespace Game.Models
{
    public abstract class Hero : GameObject, IHero
    {
        protected Hero(string id, Point location, Size objectSize, int health, int attack, int defencePoints,
            List<Item> inventory)
            : base(id, location, objectSize)
        {
            this.HealthPoints = health;
            this.AttackPoints = attack;
            this.DefencePoints = defencePoints;
            this.Items = inventory;
            this.IsAlive = true;
        }

        public int HealthPoints { get; set; }

        public int AttackPoints { get; set; }

        public int DefencePoints { get; set; }

        public List<Item> Items { get; set; }

        public bool IsAlive { get; set; }

        public void Attack(Hero enemy)
        {
            enemy.HealthPoints -= enemy.DefencePoints - this.AttackPoints;
        }

        public void ApplyItemEfect(Item i)
        {
            this.AttackPoints += i.AttackEffect;
            this.DefencePoints += i.DefenceEffect;
            this.HealthPoints += i.HealthEffect;
        }
    }
}