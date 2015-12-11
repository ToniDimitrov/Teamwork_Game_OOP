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
        Panel[] ebanieMihailovgrad = new Panel[4];
        public Game()
        {
            InitializeComponent();
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            int movementLength = 2;
            for (int i = 0; i < ebanieMihailovgrad.Length; i++)
            {
                Rectangle playerRectangle = new Rectangle(player.Location.X,player.Location.Y,player.ObjectSize.Width,player.ObjectSize.Height);
                Panel panel = ebanieMihailovgrad[i];
                Rectangle panelRectangle = new Rectangle(panel.Location.X,panel.Location.Y,panel.Width,panel.Height);

                if (playerRectangle.IntersectsWith(panelRectangle))
                {
                    movementLength = 0;
                }
                
            }
            player.Move(movementLength);
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

        private void InitBlocks()
        {
            ebanieMihailovgrad[0] = panel2;
            ebanieMihailovgrad[1] = panel3;
            ebanieMihailovgrad[2] = panel5;
            ebanieMihailovgrad[3] = panel6;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            backgroundPanel.Controls.Add(this.player.imagePlayer);
            this.player.imagePlayer.Show();
            InitBlocks();
        }
    }
}
