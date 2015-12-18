using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models;
using Game.Models.Heroes;
using Timer = System.Windows.Forms.Timer;

namespace Game
{
    public partial class BattleTownForm : Form
    {
        private readonly Player player;

        private readonly Town town;

        private int startCounter = 3;
        private int turn = 1;

        private bool fightBegan = false;
        private bool hasSomeoneDied = false;

        public BattleTownForm(Timer sendTimer, Town town, Player player)
        {
            InitializeComponent();
            this.SenderTimer = sendTimer;
            this.player = player;
            this.town = town;
        }

        public Timer SenderTimer { get; set; }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.SenderTimer.Start();
        }

        private void TownForm_Load(object sender, EventArgs e)
        {
            InitPlayerInfo();
            InitEnemyInfo();
        }

        private void InitPlayerInfo()
        {
            this.lblPlayerRace.Text = this.player.Race.ToString();
            this.lblPlayerHealth.Text = this.player.HealthPoints.ToString();
            this.lblPlayerAttack.Text = this.player.AttackPoints.ToString();
            this.lblPlayerDefence.Text = this.player.DefencePoints.ToString();
            this.pictBoxPlayer.Image = this.player.HeroImage.Image;
        }

        private void InitEnemyInfo()
        {
            this.lblEnemyRace.Text = this.town.EnemyHero.GetType().Name;
            this.lblEnemyHealth.Text = this.town.EnemyHero.HealthPoints.ToString();
            this.lblEnemyAttack.Text = this.town.EnemyHero.AttackPoints.ToString();
            this.lblEnemyDefence.Text = this.town.EnemyHero.DefencePoints.ToString();
            this.pictBoxEnemy.Image = this.town.EnemyHero.HeroImage.Image;
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            if (!fightBegan)
            {
                var BattleInformation = "";
                if (startCounter != 0)
                {
                    BattleInformation = string.Format("The battle will start in: {0}", startCounter);
                }
                else
                {
                    BattleInformation = "FIGHT!";
                    fightBegan = true;
                }

                lblBattleInformation.Text = BattleInformation;
                lblBattleInformation.TextAlign = ContentAlignment.MiddleCenter;
                startCounter--;
            }
            else
            {
                if (this.player.IsAlive && this.town.EnemyHero.IsAlive)
                {
                    int currentPlayerHealth = 0;
                    int currentEnemyHealth = 0;

                    lblTurn.Text = string.Format("Turn: {0}", turn);
                    if (turn % 2 != 0)
                    {
                        currentPlayerHealth = this.player.HealthPoints;
                        currentEnemyHealth = this.town.EnemyHero.HealthPoints;

                        lblBattleInformation.Text = @"Player attacks..";

                        Thread.Sleep(3500);

                        this.player.Attack(this.town.EnemyHero);



                        if (this.player.HealthPoints == currentPlayerHealth)
                        {
                            lblBattleInformation.Text =
                                string.Format("You attacked the enemy and took him {0} health points!",
                                    currentEnemyHealth - this.town.EnemyHero.HealthPoints);
                        }
                        else if (this.player.HealthPoints <= currentPlayerHealth)
                        {

                            lblBattleInformation.Text =
                                string.Format(
                                    "You attacked the enemy but his defence points are higher than your attack points, so you lose {0} health points",
                                    currentPlayerHealth - this.player.HealthPoints);
                        }
                        this.lblPlayerHealth.Text = this.player.HealthPoints.ToString();
                        this.lblEnemyHealth.Text = this.town.EnemyHero.HealthPoints.ToString();

                        GetBattleResult();

                        if (hasSomeoneDied)
                        {

                            this.timerBattle.Stop();
                        }
                    }
                    else
                    {
                        currentPlayerHealth = this.player.HealthPoints;
                        currentEnemyHealth = this.town.EnemyHero.HealthPoints;
                        lblBattleInformation.Text = @"Enemy Attacks..";

                        Thread.Sleep(3500);

                        this.town.EnemyHero.Attack(this.player);

                        if (this.town.EnemyHero.HealthPoints == currentEnemyHealth)
                        {
                            lblBattleInformation.Text =
                                string.Format("The enemy attacked you and took you {0} health points!",
                                    currentPlayerHealth - this.player.HealthPoints);
                        }
                        else if (this.town.EnemyHero.HealthPoints < currentEnemyHealth)
                        {
                            lblBattleInformation.Text =
                                string.Format(
                                    "The enemy attacked you but your defence points are higher than his attack points, so he loses {0} health points",
                                    currentEnemyHealth - this.town.EnemyHero.HealthPoints);
                        }
                        this.lblPlayerHealth.Text = this.player.HealthPoints.ToString();
                        this.lblEnemyHealth.Text = this.town.EnemyHero.HealthPoints.ToString();

                        GetBattleResult();

                        if (hasSomeoneDied)
                        {
                            this.timerBattle.Stop();

                        }
                    }

                    turn++;
                }
            }
        }

        private static void CheckIfIsAlive(Hero hero)
        {
            if (hero.HealthPoints <= 0)
            {
                hero.IsAlive = false;
            }
        }

        private void GetBattleResult()
        {
            CheckIfIsAlive(this.player);
            CheckIfIsAlive(this.town.EnemyHero);

            if (!this.player.IsAlive)
            {
                this.lblBattleInformation.Text = "You died! Game over!!";
                this.player.HealthPoints = 0;
                this.lblPlayerHealth.Text = "0";
                this.hasSomeoneDied = true;
            }
            if (!this.town.EnemyHero.IsAlive)
            {
                this.lblBattleInformation.Text = "You Won! Congratulations!!";
                this.town.EnemyHero.HealthPoints = 0;
                this.lblEnemyHealth.Text = "0";
                this.hasSomeoneDied = true;
                this.town.IsConquered = true;
            }
        }
    }
}
