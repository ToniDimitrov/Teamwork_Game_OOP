using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
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
        public Player player;
        private Point lastPointOutOfTown=new Point(320,370);

        Axe axeOne = new Axe("one",new Point(100,100),new Size(30,30));

        public Game()
        {
            this.direction = new Point(0, 0);
            InitializeComponent();
        }
        public void CreatePlayer(string playerName, string playerType)
        {
            PlayerRace type = (PlayerRace)Enum.Parse(typeof(PlayerRace), playerType);
            this.player = new Player("player", new Point(320, 370), new Size(30, 45),new List<Item> { new Axe("Axe", new Point(0, 0), new Size(1, 1)) },type);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    return;
            }
            Environment.Exit(0);
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            if (this.direction.X == 0 && this.direction.Y == 0) return;
            Point nextStep = this.player.NextStep(direction);
            if (IsOnTown(nextStep))
            {
                player.Move(lastPointOutOfTown);
                this.timerMovement.Stop();
                direction.X = 0;
                direction.Y = 0;              
                EnterTown();
                return;
            }
            if (ValidateMove(nextStep))
            {
                this.player.Move(nextStep);
            }
            ScrollControlIntoView(this.player.HeroImage);
        }

        private void EnterTown()
        {
            Town town = new Town(this.timerMovement);
            town.Enabled = true;
            town.Visible = true;
            town.Show();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.direction = new Point(0, 1);
                    break;
                case Keys.Up:
                    this.direction = new Point(0, -1);
                    break;
                case Keys.Left:
                    this.direction = new Point(-1, 0);
                    break;
                case Keys.Right:
                    this.direction = new Point(1, 0);
                    break;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            this.direction = new Point(0, 0);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.UnderMapWithInpassableAreas.Controls.Add(player.HeroImage);
            this.player.HeroImage.Show();
            AutoScroll = true;
            SetAutoScrollMargin(250,250);

            this.axeOne.ItemImage.Show();
        }

        public bool IsOnTown(Point nextPoint)
        {
            Point topLeftVertex = new Point(nextPoint.X, nextPoint.Y);
            Point topRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y);
            Point bottomLeftVertex = new Point(nextPoint.X, nextPoint.Y + this.player.ObjectSize.Height);
            Point bottomRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y + this.player.ObjectSize.Height);

            Color TownColor= ColorTranslator.FromHtml("#8521F5");
            Bitmap image = (Bitmap)this.UnderMapWithInpassableAreas.Image;

            if((image.GetPixel(topLeftVertex.X, topLeftVertex.Y) != TownColor) &&
                   (image.GetPixel(topRightVertex.X, topRightVertex.Y) != TownColor) &&
                   (image.GetPixel(bottomLeftVertex.X, bottomLeftVertex.Y) != TownColor) &&
                   (image.GetPixel(bottomRightVertex.X, bottomRightVertex.Y) != TownColor))
            {
                lastPointOutOfTown = nextPoint;
            }

            return (image.GetPixel(topLeftVertex.X, topLeftVertex.Y) == TownColor) &&
                   (image.GetPixel(topRightVertex.X, topRightVertex.Y) == TownColor) &&
                   (image.GetPixel(bottomLeftVertex.X, bottomLeftVertex.Y) == TownColor) &&
                   (image.GetPixel(bottomRightVertex.X, bottomRightVertex.Y) == TownColor);
        }

        public bool ValidateMove(Point nextPoint)
        {
            Point topLeftVertex = new Point(nextPoint.X, nextPoint.Y);
            Point topRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y);
            Point bottomLeftVertex = new Point(nextPoint.X, nextPoint.Y + this.player.ObjectSize.Height);
            Point bottomRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y + this.player.ObjectSize.Height);

            Color color = ColorTranslator.FromHtml("#000000");
            Bitmap image = (Bitmap)this.UnderMapWithInpassableAreas.Image;

            return ((image.GetPixel(topLeftVertex.X, topLeftVertex.Y) != color)&&
            (image.GetPixel(topRightVertex.X, topRightVertex.Y) != color) &&
            (image.GetPixel(bottomLeftVertex.X, bottomLeftVertex.Y) != color) &&
            (image.GetPixel(bottomRightVertex.X, bottomRightVertex.Y) != color));      
        }
    }
}
