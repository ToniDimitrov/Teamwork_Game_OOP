﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Game.Interfaces;

namespace Game.Models
{
    public abstract class Hero : GameObject, IHero
    {
        

        protected string pathImage;
        protected string pathImage1;
        protected string pathImage2;
        protected string pathImage3;

        protected Hero(string id, Point location, Size objectSize, int health, int attack, int defencePoints,
            List<Item> inventory, string pathImage, string pathImage1, string pathImage2, string pathImage3)
            : base(id, location, objectSize)
        {
            this.HealthPoints = health;
            this.AttackPoints = attack;
            this.DefencePoints = defencePoints;
            this.Items = inventory;
            this.IsAlive = true;
            this.pathImage = pathImage;
            this.pathImage1 = pathImage1;
            this.pathImage2 = pathImage2;
            this.pathImage3 = pathImage3;

            InitHeroImage();
            ApplyInitialItemsEffect();
        }

        protected Hero(string id, Point location, Size objectSize, List<Item> inventory)
            : base(id, location, objectSize)
        {
            this.Items = inventory;
            this.IsAlive = true;
        }

        public PictureBox HeroImage { get; set; }
        public PictureBox HeroImage1 { get; set; }
        public PictureBox HeroImage2 { get; set; }
        public PictureBox HeroImage3 { get; set; }

        public void InitHeroImage()
        {
            this.HeroImage = new PictureBox
            {
                Image = Image.FromFile(this.pathImage),
                Size = new System.Drawing.Size(this.ObjectSize.Width, this.ObjectSize.Height),
                Location = new System.Drawing.Point(this.Location.X, this.Location.Y),
                Enabled = true,
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            this.HeroImage1 = new PictureBox
            {
               
                Image = Image.FromFile(this.pathImage1),
                Size = new System.Drawing.Size(this.ObjectSize.Width, this.ObjectSize.Height),
                Location = new System.Drawing.Point(this.Location.X, this.Location.Y),
                Enabled = true,
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            this.HeroImage2 = new PictureBox
            {

                Image = Image.FromFile(this.pathImage2),
                Size = new System.Drawing.Size(this.ObjectSize.Width, this.ObjectSize.Height),
                Location = new System.Drawing.Point(this.Location.X, this.Location.Y),
                Enabled = true,
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };

            this.HeroImage3 = new PictureBox
            {

                Image = Image.FromFile(this.pathImage3),
                Size = new System.Drawing.Size(this.ObjectSize.Width, this.ObjectSize.Height),
                Location = new System.Drawing.Point(this.Location.X, this.Location.Y),
                Enabled = true,
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
        }

        public int HealthPoints { get; set; }

        public int AttackPoints { get; set; }

        public int DefencePoints { get; set; }

        public List<Item> Items { get; set; }

        public bool IsAlive { get; set; }

        public void Attack(Hero enemy)
        {
            if (enemy.DefencePoints < this.AttackPoints)
            {
                enemy.HealthPoints -= this.AttackPoints - enemy.DefencePoints;
            }
            else this.HealthPoints -= enemy.DefencePoints - this.AttackPoints;
        }

        protected void ApplyInitialItemsEffect()
        {
            foreach (var item in Items)
            {
                this.HealthPoints += item.HealthEffect;
                this.AttackPoints += item.AttackEffect;
                this.DefencePoints += item.DefenceEffect;
            }
        }
    }
}