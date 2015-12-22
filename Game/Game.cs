using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
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
        private PictureBox showItemsCountPictureBox;
        public IPlayer player;

        public Point direction;
        private Point lastPointOutOfTown = new Point(320, 370);

        private IList<ITown> towns;
        private List<Hero> enemies;
        private IList<IItem> items;

        private bool isWalkingOnLeft = true;
        private bool isOnLeftLeg = true;
        private int stepCounter;

        public Game()
        {
            this.direction = new Point(0, 0);
            InitializeComponent();
        }
        public void CreatePlayer(string playerName, string playerType)
        {
            PlayerRace type = (PlayerRace)Enum.Parse(typeof(PlayerRace), playerType);
            this.player = new Player(playerName, new Point(233, 277), new Size(30, 45), new List<IItem> { new Axe("Axe", new Point(0, 0), new Size(1, 1)) }, type);
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
            if (GetTown(nextStep) != null)
            {
                player.Move(lastPointOutOfTown);
                this.timerMovement.Stop();
                direction.X = 0;
                direction.Y = 0;
                EnterTown(GetTown(nextStep));
                return;
            }
            if (IsOnItem(nextStep))
            {
                this.player.Move(nextStep);
            }
            if (ValidateMove(nextStep))
            {
                this.player.Move(nextStep);
                this.stepCounter++;
                if (this.stepCounter %10 == 0)
                {
                    ImitateAnimation();
                }
               
            }
            ScrollControlIntoView(this.player.HeroImage);
        }

        private void ImitateAnimation()
        {
            if (isWalkingOnLeft)
            {
                if (isOnLeftLeg)
                {
                    this.player.HeroImage.Hide();
                    this.player.HeroImage1.Show();
                }
                else
                {
                    this.player.HeroImage.Show();
                    this.player.HeroImage1.Hide();
                }
                isOnLeftLeg = !isOnLeftLeg;
            }
            else
            {
                if (isOnLeftLeg)
                {
                    this.player.HeroImage2.Show();
                    this.player.HeroImage3.Hide();
                }
                else
                {
                    this.player.HeroImage2.Hide();
                    this.player.HeroImage3.Show();
                }
                isOnLeftLeg = !isOnLeftLeg;
            }
        }

        private void EnterTown(ITown town)
        {
            if (town.IsConquered == false)
            {
                BattleTownForm townForm = new BattleTownForm(this.timerMovement, town, this.player)
                {
                    Enabled = true,
                    Visible = true
                };
                townForm.Show();
            }
            else
            {
                ConqueredTownForm townForm = new ConqueredTownForm(this.timerMovement)
                {
                    Enabled = true,
                    Visible = true
                };
                townForm.Show();
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                EnterTown(towns[2]);
            }
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
                    this.isWalkingOnLeft = true;
                    break;
                case Keys.Right:
                    this.direction = new Point(1, 0);
                    this.isWalkingOnLeft = false;
                    this.player.HeroImage.Hide();
                    this.player.HeroImage1.Hide();
                    break;
                case Keys.I:
                    Key_I();
                    break;
            }
        }

        private void Key_I()
        {
            showItemsCountPictureBox.Controls[0].Text =
                string.Format("Items: {0}\nEnemy towns: {1}\n--------------\nAttack: {2}\nDefence: {3}\nHealth: {4}",
                this.player.Items.Count,
                this.towns.Count(t => !t.IsConquered),
                this.player.AttackPoints,
                this.player.DefencePoints,
                this.player.HealthPoints);

            showItemsCountPictureBox.Location = new System.Drawing.Point(this.player.Location.X, this.player.Location.Y - 70);
            showItemsCountPictureBox.Show();

            System.Timers.Timer showItemsTimer = new System.Timers.Timer(2000);
            showItemsTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);

            //set this so that the timer is stopped once the elaplsed event is fired
            showItemsTimer.AutoReset = false;
            showItemsTimer.Enabled = true;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.showItemsCountPictureBox.Hide();
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    this.direction.Y = 0;
                    break;
                default:
                    this.direction.X = 0;
                    break;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.enemies = new List<Hero>();
            this.towns = new List<ITown>();
            this.items = new List<IItem>();
            Init();
        }

        private void Init()
        {
            InitEnemies();
            InitTowns();
            InitItem();

            this.UnderMapWithInpassableAreas.Controls.Add(player.HeroImage);
            this.UnderMapWithInpassableAreas.Controls.Add(player.HeroImage1);
            this.UnderMapWithInpassableAreas.Controls.Add(player.HeroImage2);
            this.UnderMapWithInpassableAreas.Controls.Add(player.HeroImage3);

            this.showItemsCountPictureBox = new PictureBox
            {
                Image = Image.FromFile("testShowItemsCount.png"),
                Size = new System.Drawing.Size(200, 70),
                Location = new System.Drawing.Point(this.Width / 2, this.Height / 2),
            };
            showItemsCountPictureBox.Visible = false;
            Label itemsCountLabel = new Label { Height = 50 };
            showItemsCountPictureBox.Controls.Add(itemsCountLabel);
            showItemsCountPictureBox.Controls.SetChildIndex(itemsCountLabel, 0);
            this.UnderMapWithInpassableAreas.Controls.Add(showItemsCountPictureBox);

            this.player.HeroImage.Show();
            this.player.HeroImage1.Show();
            this.player.HeroImage2.Show();
            this.player.HeroImage3.Show();

            AutoScroll = true;
            SetAutoScrollMargin(250, 250);
        }

        private void InitItem()
        {
            IList<IItem> itemList = new List<IItem>
           {
               new Axe("Axe 1",new Point(190, 350),new Size(33, 33)),
               new Sword("Sword 1",new Point(788, 529),new Size(33, 33)),
               new Sword("Sword 2",new Point(1654, 1371),new Size(33, 33)),
               new Shield("Shield 1",new Point(1008, 1150),new Size(33, 33)),
               new Shield("Shield 2",new Point(1357, 1333),new Size(33, 33)),
               new Spear("Spear 1",new Point(902, 1612),new Size(60, 16)),
               new Spear("Spear 1",new Point(1100, 264),new Size(60, 16)),
               new HealthPotion("HealthPotion 1",new Point(1135, 459),new Size(33, 33)),
               new HealthPotion("HealthPotion 2",new Point(629, 450),new Size(33, 33)),
               new HealthPotion("HealthPotion 3",new Point(744, 1100),new Size(33, 33)),
               new HealthPotion("HealthPotion 4",new Point(1670, 1538),new Size(33, 33))
           };
            foreach (var item in itemList)
            {
                this.UnderMapWithInpassableAreas.Controls.Add(item.ItemImage);
                item.ItemImage.Show();
                this.items.Add(item);
            }
        }

        private void InitTowns()
        {
            this.towns = new List<ITown>
            {
                new Town("Town Player", new Point(216, 180), new Size(110, 60), this.player, true),
                new Town("Town Enemy 1", new Point(674, 659), new Size(83, 39), this.enemies[0], false),
                new Town("Town Enemy 2", new Point(200, 1683), new Size(118, 65), this.enemies[1], false),
                new Town("Town Enemy 3", new Point(1751, 201), new Size(87, 59), this.enemies[2], false),
                new Town("Town Enemy 4", new Point(1739, 1666), new Size(84, 70), this.enemies[3], false),
                new Town("Town Enemy 5", new Point(1066, 1601), new Size(117, 69), this.enemies[4], false)
            };

        }

        private void InitEnemies()
        {
            List<Hero> enemiesList = new List<Hero>
            {
                new Spartan("Enemy 1",new Point(674, 691), new Size(161, 153),
                    new List<IItem> {new Sword("Sword Enemy 1", new Point(1, 1), new Size(1, 1))}),

                new Viking("Enemy 2", new Point(200, 1658), new Size(161, 153),
                    new List<IItem> {new Axe("Axe Enemy 2", new Point(1, 1), new Size(1, 1))}),

                new Barbarian("Enemy 3", new Point(1741, 201), new Size(161, 153),
                    new List<IItem>
                    {
                        new Axe("Axe 1 Enemy 3", new Point(1741, 201), new Size(1, 1)),
                        new Axe("Axe 2 Enemy 3", new Point(1741, 201), new Size(1, 1))
                    }),

                new Viking("Enemy 4", new Point(1739, 1666), new Size(161, 153),
                    new List<IItem>
                    {
                        new Axe("Axe Enemy 4", new Point(1739, 1666), new Size(1, 1)),
                        new Shield("Shield Enemy 4", new Point(1739, 1666), new Size(1, 1))
                    }),

                new Spartan("Enemy 5", new Point(1066, 1651), new Size(161, 153),
                    new List<IItem>
                    {
                        new Spear("Spear Enemy 5", new Point(1066, 1651), new Size(1, 1)),
                        new Shield("Shield Enemy 5", new Point(1066, 1651), new Size(1, 1))
                    })
            };
            this.enemies.AddRange(enemiesList);
        }

        public bool IsOnItem(Point nextPoint)
        {
            Rectangle playerRectangle = new Rectangle(nextPoint.X, nextPoint.Y,
               this.player.ObjectSize.Width, this.player.ObjectSize.Height);
            Rectangle itemRectangle = new Rectangle();

            foreach (var item in items)
            {
                itemRectangle = new Rectangle(item.Location.X, item.Location.Y, item.ObjectSize.Width, item.ObjectSize.Height);
                if (playerRectangle.IntersectsWith(itemRectangle))
                {
                    this.player.AddItem(item);
                    item.ItemImage.Hide();
                    this.items.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public ITown GetTown(Point nextPoint)
        {
            Rectangle playerRectangle = new Rectangle(nextPoint.X, nextPoint.Y,
                this.player.ObjectSize.Width, this.player.ObjectSize.Height);

            Rectangle townRectangle = new Rectangle();
            foreach (var town in towns)
            {
                townRectangle = new Rectangle(town.Location.X, town.Location.Y, town.ObjectSize.Width, town.ObjectSize.Height);
                if (playerRectangle.IntersectsWith(townRectangle))
                {
                    return town;
                }
            }

            lastPointOutOfTown = nextPoint;
            return null;
        }

        public bool ValidateMove(Point nextPoint)
        {
            Point topLeftVertex = new Point(nextPoint.X, nextPoint.Y);
            Point topRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y);
            Point bottomLeftVertex = new Point(nextPoint.X, nextPoint.Y + this.player.ObjectSize.Height);
            Point bottomRightVertex = new Point(nextPoint.X + this.player.ObjectSize.Width, nextPoint.Y + this.player.ObjectSize.Height);

            Color color = ColorTranslator.FromHtml("#000000");
            Bitmap image = (Bitmap)this.UnderMapWithInpassableAreas.Image;

            return ((image.GetPixel(topLeftVertex.X, topLeftVertex.Y + 15) != color) &&
            (image.GetPixel(topRightVertex.X, topRightVertex.Y + 15) != color) &&
            (image.GetPixel(bottomLeftVertex.X, bottomLeftVertex.Y) != color) &&
            (image.GetPixel(bottomRightVertex.X, bottomRightVertex.Y) != color));
        }
    }
}
