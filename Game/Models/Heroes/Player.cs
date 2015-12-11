using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ConsoleApplication5.Interfaces;
using Size = ConsoleApplication5.Models.Size;

namespace Game.Models.Heroes
{
    public class Player : Hero, IPlayer
    {
        private bool playerUp = false;
        private bool playerDown = false;
        private bool playerLeft = false;
        private bool playerRight = false;
        private PictureBox imagePlayer;

        public Player(string id, Point location, Size objectSize, int health, int attack, int defencePoints,
            List<Item> items) :
                base(id, location, objectSize, health, attack, defencePoints, items)
        {
            InitImagePlayer();
        }

        public void InitImagePlayer()
        {
            this.imagePlayer.Image = Image.FromFile("spartan.jpg");
            this.imagePlayer.
        }

        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.Items.Remove(item);
        }

        public void Move()
        {
            if (playerDown)
            {
                this.Location
            }
        }

   
    }
}