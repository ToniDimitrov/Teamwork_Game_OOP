using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Player player = new Player("player", new Point(20, 20), new Size(30, 45), 100, 100, 100,
            new List<Item> {new Axe("Axe", new Point(0, 0), new Size(1, 1))});

        public Game()
        {
            InitializeComponent();
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            int movementLength = 2;

            if (this.player.playerDown)
            {
                 this.player.Move(movementLength,this.UnderMapWithInpassableAreas);
            }
            else if (this.player.playerUp)
            {
                this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
            }
            else if (this.player.playerLeft)
            {
                this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
            }
            else if (this.player.playerRight)
            {
                this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
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
            this.Map.Controls.Add(player.imagePlayer);
            this.player.imagePlayer.Show();
            AutoScroll = true;
            SetAutoScrollMargin(250,250);
        }
    }
}
