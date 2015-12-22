using System.Collections.Generic;
using Game.Interfaces;

namespace Game.Models.Heroes
{
    public class Player : Hero, IPlayer
    {
        private const int stepLength = 2;
        public PlayerRace Race { get; set; }

        public Player(string id, Point location, Size objectSize, IList<IItem> items, PlayerRace playerRace)
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
                    this.AttackPoints = 30;
                    this.DefencePoints = 25;
                    this.HealthPoints = 125;
                    this.pathImage = "Barbarian.png";
                    this.pathImage1 = "barbarian2.png";
                    this.pathImage2 = "barbarian1.png";
                    this.pathImage3 = "Barbarian3.png";


                    break;
                case PlayerRace.Spartan:
                    this.AttackPoints = 25;
                    this.DefencePoints = 35;
                    this.HealthPoints = 110;
                    this.pathImage = "Spartan.png";
                    this.pathImage1 = "Spartan1.png";
                    this.pathImage2 = "RevertedSpartan.png";
                    this.pathImage3 = "RevertedSpartan1.png";

                    break;
                case PlayerRace.Viking:
                    this.AttackPoints = 30;
                    this.DefencePoints = 18;
                    this.HealthPoints = 120;
                    this.pathImage = "Viking2.png";
                    this.pathImage1 = "Viking3.png";
                    this.pathImage2 = "Viking.png";
                    this.pathImage3 = "Viking1.png";

                    break;
            }
        }

        public void AddItem(IItem item)
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
            this.HeroImage1.Location = new System.Drawing.Point(destination.X, destination.Y);
            this.HeroImage2.Location = new System.Drawing.Point(destination.X, destination.Y);
            this.HeroImage3.Location = new System.Drawing.Point(destination.X, destination.Y);

        }

        public void ApplyItemEffect(IItem item)
        {
            this.AttackPoints += item.AttackEffect;
            this.DefencePoints += item.DefenceEffect;
            this.HealthPoints += item.HealthEffect;
            }

        public void RemoveItemEffect(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            this.DefencePoints -= item.DefenceEffect;
            this.HealthPoints -= item.HealthEffect;
            }
    }
}