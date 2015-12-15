using System;
using System.Drawing;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models;

namespace Game.Models
{
    public abstract class Item : GameObject, IItem
    {
        private int attackEffect;
        private int defenceEffect;
        private int healthEffect;

        public PictureBox ItemImage { get; set; }

        private string pathImage;
        
        protected Item(string id, Point location, Size objectSize, int attackEffect, int defenceEffect, int healthEffect, string pathImage)
            : base(id, location, objectSize)
        {
            this.AttackEffect = attackEffect;
            this.DefenceEffect = defenceEffect;
            this.HealthEffect = healthEffect;
            this.pathImage = pathImage;

            InitItemImage();
        }

        public void InitItemImage()
        {
            this.ItemImage = new PictureBox
            {
                Image = Image.FromFile(this.pathImage),
                Size = new System.Drawing.Size(this.ObjectSize.Width, this.ObjectSize.Height),
                Location = new System.Drawing.Point(this.Location.X, this.Location.Y),
                Enabled = true,
                Visible = true,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
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