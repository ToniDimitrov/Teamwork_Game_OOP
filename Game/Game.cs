using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Game.Models;
using Game.Models.Heroes;
using Game.Models.Items;
using Point = Game.Models.Point;
using Size = Game.Models.Size;

namespace Game
{
    public partial class Game : Form
    {
        private int rightBorder;
        private int leftBorder;
        private int upperBorder;
        private int downBorder;
        private Player player = new Player("player", new Point(20, 20), new Size(30, 45), 100, 100, 100,
            new List<Item> { new Axe("Axe", new Point(0, 0), new Size(1, 1)) });

        public Game()
        {
            InitializeComponent();
            rightBorder = 2 * this.Width / 3;
            leftBorder = this.Width / 3;
            upperBorder = this.Height / 3;
            downBorder = 2 * this.Height / 3;
        }



        private void timerMovement_Tick(object sender, EventArgs e)
        {
            int movementLength = 2;

            if (this.player.playerDown)
            {
                if (this.player.imagePlayer.Top > downBorder && this.Map.Top > -(this.Map.Height - this.Height))
                {
                    this.Map.Top -= 2;
                    this.UnderMapWithInpassableAreas.Top -= 2;
                }
                else
                {
                    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
                }
            }
            else if (this.player.playerUp)
            {
                if (this.player.imagePlayer.Top < upperBorder && this.Map.Top < 0)
                {
                    this.Map.Top += 2;
                    this.UnderMapWithInpassableAreas.Top += 2;
                }
                else
                {
                    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
                }
            }
            else if (this.player.playerLeft)
            {
                if (this.player.imagePlayer.Left < leftBorder && this.Map.Left < 0)
                {
                    this.Map.Left += 2;
                    this.UnderMapWithInpassableAreas.Left += 2;
                }
                else
                {
                    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
                }
            }
            else if (this.player.playerRight)
            {
                if (this.player.imagePlayer.Left > rightBorder && this.Map.Left > -(this.Map.Width - this.Width))
                {
                    this.Map.Left -= 2;
                    this.UnderMapWithInpassableAreas.Left -= 2;
                }
                else
                {
                    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
                }
            }


        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.player.playerDown = true;
                    break;
                case Keys.Up:
                    this.player.playerUp = true;
                    break;
                case Keys.Left:
                    this.player.playerLeft = true;
                    break;
                case Keys.Right:
                    this.player.playerRight = true;
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.player.playerDown = false;
                    break;
                case Keys.Up:
                    this.player.playerUp = false;
                    break;
                case Keys.Left:
                    this.player.playerLeft = false;
                    break;
                case Keys.Right:
                    this.player.playerRight = false;
                    break;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Controls.Add(this.player.imagePlayer);
            this.player.imagePlayer.BringToFront();
            this.player.imagePlayer.Show();
        }
    }
}
