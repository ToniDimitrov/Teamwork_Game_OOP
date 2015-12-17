using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models;
using Game.Models.Heroes;
using Game.Models.Items;
using Point = Game.Models.Point;
using Size = Game.Models.Size;

namespace Game
{
    public partial class Game : Form
    {
        public Player player;

        public Point direction;
        private Point lastPointOutOfTown=new Point(320,370);

        private List<Town> towns;
        private List<Hero> enemies;
        Axe axeOne = new Axe("one",new Point(100,100),new Size(30,30));

        public Game()
        {
            this.direction = new Point(0, 0);
            InitializeComponent();
        }
        public void CreatePlayer(string playerName, string playerType)
        {
            PlayerRace type = (PlayerRace)Enum.Parse(typeof(PlayerRace), playerType);
            this.player = new Player("player", new Point(233, 277), new Size(30, 45),new List<Item> { new Axe("Axe", new Point(0, 0), new Size(1, 1)) },type);
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
            TownForm town = new TownForm(this.timerMovement);
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
            this.enemies = new List<Hero>();
            this.towns = new List<Town>();
            Init();
        }

        private void Init()
        {
            InitEnemies();
            InitTowns();

            this.UnderMapWithInpassableAreas.Controls.Add(player.HeroImage);
            this.player.HeroImage.Show();
            AutoScroll = true;
            SetAutoScrollMargin(250, 250);

            this.axeOne.ItemImage.Show();
        }

        private void InitTowns()
        {
            this.towns = new List<Town>
            {
                new Town("Town Player", new Point(226, 187), new Size(117, 69), this.player, true),
                new Town("Town Enemy 1", new Point(674, 691), new Size(93, 39), this.enemies[0], false),
                new Town("Town Enemy 2", new Point(200, 1658), new Size(118, 65), this.enemies[1], false),
                new Town("Town Enemy 3", new Point(1741, 201), new Size(87, 59), this.enemies[2], false),
                new Town("Town Enemy 4", new Point(1739, 1666), new Size(84, 70), this.enemies[3], false),
                new Town("Town Enemy 5", new Point(1066, 1651), new Size(117, 69), this.enemies[4], false)
            };

        }

        private void InitEnemies()
        {
            List<Hero> enemiesList = new List<Hero>
            {
                new Spartan("Enemy 1",new Point(674, 691), new Size(161, 153),
                    new List<Item> {new Sword("Sword Enemy 1", new Point(1, 1), new Size(1, 1))}),

                new Viking("Enemy 2", new Point(200, 1658), new Size(161, 153),
                    new List<Item> {new Axe("Axe Enemy 2", new Point(1, 1), new Size(1, 1))}),

                new Barbarian("Enemy 3", new Point(1741, 201), new Size(161, 153),
                    new List<Item>
                    {
                        new Axe("Axe 1 Enemy 3", new Point(1741, 201), new Size(1, 1)),
                        new Axe("Axe 2 Enemy 3", new Point(1741, 201), new Size(1, 1))
                    }),

                new Viking("Enemy 4", new Point(1739, 1666), new Size(161, 153),
                    new List<Item>
                    {
                        new Axe("Axe Enemy 4", new Point(1739, 1666), new Size(1, 1)),
                        new Shield("Shield Enemy 4", new Point(1739, 1666), new Size(1, 1))
                    }),

                new Spartan("Enemy 5", new Point(1066, 1651), new Size(161, 153),
                    new List<Item>
                    {
                        new Spear("Spear Enemy 5", new Point(1066, 1651), new Size(1, 1)),
                        new Shield("Shield Enemy 5", new Point(1066, 1651), new Size(1, 1))
                    })
            };
            this.enemies.AddRange(enemiesList);
        }

        public bool IsOnTown(Point nextPoint)
        {
            Rectangle playerRectangle = new Rectangle(nextPoint.X, nextPoint.Y,
                this.player.ObjectSize.Width, this.player.ObjectSize.Height);

            Rectangle townRectangle = new Rectangle();
            foreach (var town in towns)
            {
                townRectangle = new Rectangle(town.Location.X,town.Location.Y,town.ObjectSize.Width,town.ObjectSize.Height);
                if (playerRectangle.IntersectsWith(townRectangle))
                {
                    return true;
                }
            }

            lastPointOutOfTown = nextPoint;
            return false;
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
