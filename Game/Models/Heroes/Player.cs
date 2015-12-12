using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Game.Interfaces;

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
            this.imagePlayer.Image = Image.FromFile("Spartan30-45.jpg");
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

        public void Move(int movementLenght, PictureBox pictBox)
        {
            Point locationBeforeMovement = new Point(this.Location.X,this.Location.Y);
            Point nextPoint = new Point(this.Location.X, this.Location.Y);

            if (playerDown)
            {
                nextPoint = new Point(this.Location.X, this.Location.Y + movementLenght);
            }
            else if (playerUp)
            {
                nextPoint = new Point(this.Location.X, this.Location.Y - movementLenght);
            }
            else if (playerLeft)
            {
                nextPoint = new Point(this.Location.X - movementLenght, this.Location.Y);
            }
            else if (playerRight)
            {
                nextPoint = new Point(this.Location.X + movementLenght, this.Location.Y);
            }

            if (ValidateMove(pictBox, nextPoint))
            {
                this.Location = nextPoint;
            }
            else this.Location = locationBeforeMovement;

            this.imagePlayer.Location = new System.Drawing.Point(this.Location.X,this.Location.Y);
        }

        private bool ValidateMove(PictureBox pictBox, Point nextPoint)
        {
            return (((Bitmap)pictBox.Image).GetPixel(nextPoint.X, nextPoint.Y) !=
                    ColorTranslator.FromHtml("#000000"));
        }
    }
}