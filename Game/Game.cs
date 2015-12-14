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
        public Point direction;
        private Player player = new Player("player", new Point(20, 20), new Size(30, 45), 100, 100, 100,
            new List<Item> {new Axe("Axe", new Point(0, 0), new Size(1, 1))});

        public Game()
        {
            this.direction = new Point(0, 0);
            InitializeComponent();
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            if (this.direction.X != 0 || this.direction.Y != 0)
            {
                Point nextStep = this.player.NextStep(direction);

                if (ValidateMove(nextStep))
                {
                    this.player.Move(nextStep);
                    ScrollControlIntoView(this.player.imagePlayer);
                }
            }

            //if (this.player.playerDown)
            //{
            //     this.player.Move(movementLength,this.UnderMapWithInpassableAreas);
            //}
            //else if (this.player.playerUp)
            //{
            //    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
            //}
            //else if (this.player.playerLeft)
            //{
            //    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
            //}
            //else if (this.player.playerRight)
            //{
            //    this.player.Move(movementLength, this.UnderMapWithInpassableAreas);
            //}

            //if (this.player.Location.Y + this.player.imagePlayer.Size.Height + this.AutoScrollMargin.Height <
            //    this.Map.Height)
            //{
            //    if (this.player.Location.X + this.player.imagePlayer.Size.Width + this.AutoScrollMargin.Width <
            //        this.Map.Width)
            //    {
            //        ScrollControlIntoView(this.player.imagePlayer);
            //    }
            //}
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    //this.player.playerDown = true;
                    this.direction = new Point(0, 1);
                    break;
                case Keys.Up:
                    //this.player.playerUp = true;
                    this.direction = new Point(0, -1);
                    break;
                case Keys.Left:
                    //this.player.playerLeft = true;
                    this.direction = new Point(-1, 0);
                    break;
                case Keys.Right:
                    //this.player.playerRight = true;
                    this.direction = new Point(1, 0);
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            this.direction = new Point(0, 0);
            //switch (e.KeyCode)
            //{
                //case Keys.Down:
                //    this.player.playerDown = false;
                //    break;
                //case Keys.Up:
                //    this.player.playerUp = false;
                //    break;
                //case Keys.Left:
                //    this.player.playerLeft = false;
                //    break;
                //case Keys.Right:
                //    this.player.playerRight = false;
                //    break;
            //}
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Map.Controls.Add(player.imagePlayer);
            this.player.imagePlayer.Show();
            AutoScroll = true;
            SetAutoScrollMargin(250,250);
        }

        public bool ValidateMove(Point nextPoint)
        {
            Point topLeftVertex = new Point(nextPoint.X, nextPoint.Y);
            Point topRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y);
            Point bottomLeftVertex = new Point(nextPoint.X, nextPoint.Y + this.player.ObjectSize.Height);
            Point bottomRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y + this.player.ObjectSize.Height);

            Color color = ColorTranslator.FromHtml("#000000");
            Bitmap image = (Bitmap)this.UnderMapWithInpassableAreas.Image;

            return (image.GetPixel(topLeftVertex.X, topLeftVertex.Y) != color) &&
                   (image.GetPixel(topRightVertex.X, topRightVertex.Y) != color) &&
                   (image.GetPixel(bottomLeftVertex.X, bottomLeftVertex.Y) != color) &&
                   (image.GetPixel(bottomRightVertex.X, bottomRightVertex.Y) != color);
        }
    }
}
