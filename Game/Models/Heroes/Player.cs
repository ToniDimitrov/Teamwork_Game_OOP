using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Game.Interfaces;
using Size = Game.Models.Size;

namespace Game.Models.Heroes
{
    public class Player : Hero, IPlayer
    {
        public bool playerUp = false;
        public bool playerDown = false;
        public bool playerLeft = false;
        public bool playerRight = false;
        public PictureBox imagePlayer;

        public Player(string id, Point location, Size objectSize, int health, int attack, int defencePoints,
            List<Item> items) :
                base(id, location, objectSize, health, attack, defencePoints, items)
        {
            InitImagePlayer();
        }

        public void InitImagePlayer()
        {
            this.imagePlayer = new PictureBox();
            this.imagePlayer.Image = Image.FromFile("spartan.jpg");
            this.imagePlayer.Size = new System.Drawing.Size(this.ObjectSize.Width,this.ObjectSize.Height);
            this.imagePlayer.Location = new System.Drawing.Point(this.Location.X,this.Location.Y);
            this.imagePlayer.Enabled = true;
            this.imagePlayer.Visible = true;
        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.Items.Remove(item);
        }

        public void Move(int movementLenght)
        {
            if (playerDown)
            {
               this.Location= new Point(this.Location.X,this.Location.Y+movementLenght);
                this.imagePlayer.Location = new System.Drawing.Point(this.Location.X,this.Location.Y);
            }
            else if (playerUp)
            {
                this.Location = new Point(this.Location.X, this.Location.Y - movementLenght);
                this.imagePlayer.Location = new System.Drawing.Point(this.Location.X, this.Location.Y);
            }
            else if (playerLeft)
            {
                this.Location = new Point(this.Location.X - movementLenght, this.Location.Y);
                this.imagePlayer.Location = new System.Drawing.Point(this.Location.X, this.Location.Y);
            }
            else if (playerRight)
            {
                this.Location = new Point(this.Location.X + movementLenght, this.Location.Y);
                this.imagePlayer.Location = new System.Drawing.Point(this.Location.X, this.Location.Y);
            }
        }

   
    }
}