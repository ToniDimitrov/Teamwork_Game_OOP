using System;
using ConsoleApplication5.Models;

namespace Game.Models
{
    public abstract class Item : GameObject
    {
        private int attackEffect;
        private int defenceEffect;
        private int healthEffect;

        protected Item(string id, Point location, Size objectSize, int attackEffect, int defenceEffect,
            int healthEffect) : base(id, location, objectSize)
        {
            this.AttackEffect = attackEffect;
            this.DefenceEffect = defenceEffect;
            this.HealthEffect = healthEffect;
        }

        public int AttackEffect
        {
            get { return this.attackEffect; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack effect of item cannot be negative");
                }
                this.attackEffect = value;
            }
        }

        public int DefenceEffect
        {
            get { return this.defenceEffect; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Defence effect of item cannot be negative");
                }
                this.defenceEffect = value;
            }
        }

        public int HealthEffect
        {
            get { return this.healthEffect; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Health effect of item cannot be negative");
                }
                this.healthEffect = value;
            }
        }
    }
}