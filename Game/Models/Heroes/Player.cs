using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Game.Interfaces;

namespace Game.Models.Heroes
{
    public class Player : Hero, IPlayer
    {
        private const int stepLength = 2;
        public PlayerRace Race { get; set; }

        public Player(string id, Point location, Size objectSize, List<Item> items, PlayerRace playerRace)
            : base(id, location, objectSize, items)
        {
            this.Race = playerRace;
            SetCharachteristics();
            ApplyInitialItemsEffect();

            this.InitHeroImage();

        }

        private void SetCharachteristics()
        {
            switch (this.Race)
            {
                case PlayerRace.Barbarian:
                    this.HealthPoints = 125;
                    this.AttackPoints = 30;
                    this.DefencePoints = 25;
                    this.pathImage = "Barbarian.png";
                    break;
                case PlayerRace.Spartan:
                    this.HealthPoints = 110;
                    this.AttackPoints = 25;
                    this.DefencePoints = 35;
                    this.pathImage = "Spartan.png";
                    break;
                case PlayerRace.Viking:
                    this.HealthPoints = 120;
                    this.AttackPoints = 30;
                    this.DefencePoints = 18;
                    this.pathImage = "Viking.png";
                    break;
            }
        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
            this.ApplyItemEffect(item);
        }

        public void RemoveItem(Item item)
        {
            this.Items.Remove(item);
            RemoveItemEffect(item);
        }

        public Point NextStep(Point direction)
        {
            return new Point(this.Location.X + stepLength * direction.X, this.Location.Y
                + stepLength * direction.Y);
        }

        public void Move(Point destination)
        {
            this.Location = destination;
            this.HeroImage.Location = new System.Drawing.Point(destination.X, destination.Y);
        }

        public void ApplyItemEffect(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.AttackPoints += item.AttackEffect;
            this.DefencePoints += item.DefenceEffect;
        }

        public void RemoveItemEffect(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.AttackPoints -= item.AttackEffect;
            this.DefencePoints -= item.DefenceEffect;

        }
    }
}