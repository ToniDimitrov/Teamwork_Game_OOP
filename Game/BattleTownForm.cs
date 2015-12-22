using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private int NumberCounting = 3;
        private int ImageChangeInex = 1;
        private readonly Player player;

        private readonly Town town;
        private Image PlayerImage;
        private Image EnemyImage;

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
            this.lblPlayer.Text = this.player.Id;
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
            string pathImage = player.Race.ToString() + "Attacks/Left/0.png";
            this.pictBoxPlayer.BackgroundImage = Image.FromFile(pathImage);
            this.PlayerImage = Image.FromFile(pathImage);
        }

        private void InitEnemyInfo()
        {
            this.lblEnemyRace.Text = this.town.EnemyHero.GetType().Name;
            this.lblEnemyHealth.Text = this.town.EnemyHero.HealthPoints.ToString();
            this.lblEnemyAttack.Text = this.town.EnemyHero.AttackPoints.ToString();
            this.lblEnemyDefence.Text = this.town.EnemyHero.DefencePoints.ToString();
            string pathImage = town.EnemyHero.GetType().Name + "Attacks/Right/0.png";
            this.pictBoxEnemy.BackgroundImage = Image.FromFile(pathImage);
            this.EnemyImage=Image.FromFile(pathImage);
        }

        private void timerBattle_Tick(object sender, EventArgs e)
        {
            if (!fightBegan)
            {
                var BattleInformation = "";
                if (startCounter != 0)
                {
                    string pathImage = "FightCounting/" + NumberCounting.ToString() + ".png";
                    if (NumberCounting > 0)
                    {
                        this.TblCounting.BackgroundImage = Image.FromFile(pathImage);
                        this.NumberCounting--;
                    }

                }
                else
                {
                    string pathImage = "FightCounting/Fight.png";
                    this.TblCounting.BackgroundImage = Image.FromFile(pathImage);
                    this.LblTurnNumber.Text = turn.ToString();
                    this.TblTurns.Visible = true;                  
                    fightBegan = true;
                }
                              
                startCounter--;
            }
            else
            {
                string turnStr = turn.ToString();
                this.LblTurnNumber.Text = turnStr;
                if (this.player.IsAlive && this.town.EnemyHero.IsAlive)
                {
                    int currentPlayerHealth = 0;
                    int currentEnemyHealth = 0;
                                                 
                    if (turn % 2 != 0)
                    {
                        timer1.Stop();
                        pictBoxPlayer.BackgroundImage = PlayerImage;
                        timer2.Start();
                                              
                        currentPlayerHealth = this.player.HealthPoints;
                        currentEnemyHealth = this.town.EnemyHero.HealthPoints;

                        lblBattleInformation.Text = @"Enemy attacks..";
                        tableLayoutPanel1.Visible = true;
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = "RageOfBlades.wav";
                        player.Load();
                        player.Play();
                        //Thread.Sleep(3500);
                     
                        this.player.Attack(this.town.EnemyHero);


                        if (this.player.HealthPoints == currentPlayerHealth)
                        {
                            string text = "-" + (currentEnemyHealth - this.town.EnemyHero.HealthPoints);
                            this.LblEnemyMinusHealth.Text = text; 
                            TblEnemyMinusHealth.Visible = true;                          
                        }
                        else if (this.player.HealthPoints <= currentPlayerHealth)
                        {

                            this.LblPlayerMinusHealh.Text = string.Format("-{0}",(currentPlayerHealth - this.player.HealthPoints));
                            TblPlayerMinusHealth.Visible = true;         
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
                        timer1.Start();
                        timer2.Stop();                       
                        pictBoxEnemy.BackgroundImage = EnemyImage;
                        currentPlayerHealth = this.player.HealthPoints;
                        currentEnemyHealth = this.town.EnemyHero.HealthPoints;
                        lblBattleInformation.Text = @"Player Attacks..";

                        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                        player.SoundLocation = "RageOfBlades.wav";
                        player.Load();
                        player.Play();
                        //Thread.Sleep(3500);

                        this.town.EnemyHero.Attack(this.player);

                        if (this.town.EnemyHero.HealthPoints == currentEnemyHealth)
                        {

                            this.LblPlayerMinusHealh.Text = string.Format("-{0}",(currentPlayerHealth - this.player.HealthPoints));
                            TblPlayerMinusHealth.Visible = true;

                        }
                        else if (this.town.EnemyHero.HealthPoints < currentEnemyHealth)
                        {
                            string text = "-" + (currentEnemyHealth - this.town.EnemyHero.HealthPoints);
                            this.LblEnemyMinusHealth.Text = text;
                            TblEnemyMinusHealth.Visible = true;
                        }
                        this.lblPlayerHealth.Text = this.player.HealthPoints.ToString();
                        this.lblEnemyHealth.Text = this.town.EnemyHero.HealthPoints.ToString();

                        GetBattleResult();

                        if (hasSomeoneDied)
                        {
                            this.timerBattle.Stop();
                            this.timer1.Stop();
                            this.timer2.Stop();

                        }
                    }

                    turn++;                    
                    timerBattle.Enabled=true;
                }
            }
        }

        private void AnimatePlayerAttack()
        {
            
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

        private void TblPlayerInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TunrMovesTimer_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("aaaaaaaaaaa");
            if (ImageChangeInex > 4)
            {
                ImageChangeInex = 1;
            }
            string pathImage = player.Race.ToString() + "Attacks/Left/"+ImageChangeInex+".png";
            this.pictBoxPlayer.BackgroundImage=Image.FromFile(pathImage);
            ImageChangeInex++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ImageChangeInex > 4)
            {
                ImageChangeInex = 1;
            }
            string pathImage = town.EnemyHero.GetType().Name + "Attacks/Right/" + ImageChangeInex + ".png";
            this.pictBoxEnemy.BackgroundImage = Image.FromFile(pathImage);
            ImageChangeInex++;
        }
    }

    
}
