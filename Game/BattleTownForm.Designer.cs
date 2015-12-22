namespace Game
{
    partial class BattleTownForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleTownForm));
            this.pictBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictBoxEnemy = new System.Windows.Forms.PictureBox();
            this.PicBoxVS = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayerAttack = new System.Windows.Forms.Label();
            this.lblEnemyDefence = new System.Windows.Forms.Label();
            this.lblEnemyAttack = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblEnemyRace = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.LblPlayerDefenceInfo = new System.Windows.Forms.Label();
            this.LblPlayerAttackInfo = new System.Windows.Forms.Label();
            this.LblPlayerHealthInfo = new System.Windows.Forms.Label();
            this.LblPlayerRaceInfo = new System.Windows.Forms.Label();
            this.LblEnemyDefenceInfo = new System.Windows.Forms.Label();
            this.LblEnemyAttackInfo = new System.Windows.Forms.Label();
            this.LblEnemyHealthInfo = new System.Windows.Forms.Label();
            this.LblEnemyRaceInfo = new System.Windows.Forms.Label();
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            this.TblPlayerInformation = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayerRace = new System.Windows.Forms.Label();
            this.lblPlayerDefence = new System.Windows.Forms.Label();
            this.TblEnemyInformation = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TblCounting = new System.Windows.Forms.TableLayoutPanel();
            this.TblTurns = new System.Windows.Forms.TableLayoutPanel();
            this.PicBoxTurn = new System.Windows.Forms.PictureBox();
            this.LblTurnNumber = new System.Windows.Forms.Label();
            this.TblPlayerMinusHealth = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblPlayerMinusHealh = new System.Windows.Forms.Label();
            this.TblEnemyMinusHealth = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblEnemyMinusHealth = new System.Windows.Forms.Label();
            this.lblBattleInformation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxVS)).BeginInit();
            this.TblPlayerInformation.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TblEnemyInformation.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.TblTurns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxTurn)).BeginInit();
            this.TblPlayerMinusHealth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TblEnemyMinusHealth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBoxPlayer
            // 
            this.pictBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictBoxPlayer.BackgroundImage")));
            this.pictBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictBoxPlayer.Location = new System.Drawing.Point(115, 264);
            this.pictBoxPlayer.Name = "pictBoxPlayer";
            this.pictBoxPlayer.Size = new System.Drawing.Size(240, 300);
            this.pictBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxPlayer.TabIndex = 1;
            this.pictBoxPlayer.TabStop = false;
            // 
            // pictBoxEnemy
            // 
            this.pictBoxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pictBoxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictBoxEnemy.Location = new System.Drawing.Point(430, 264);
            this.pictBoxEnemy.Name = "pictBoxEnemy";
            this.pictBoxEnemy.Size = new System.Drawing.Size(240, 300);
            this.pictBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxEnemy.TabIndex = 2;
            this.pictBoxEnemy.TabStop = false;
            // 
            // PicBoxVS
            // 
            this.PicBoxVS.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxVS.Image")));
            this.PicBoxVS.Location = new System.Drawing.Point(364, 416);
            this.PicBoxVS.Name = "PicBoxVS";
            this.PicBoxVS.Size = new System.Drawing.Size(50, 50);
            this.PicBoxVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxVS.TabIndex = 3;
            this.PicBoxVS.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Black;
            this.lblPlayer.Location = new System.Drawing.Point(85, 1);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(52, 17);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player:";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.ForeColor = System.Drawing.Color.Red;
            this.lblPlayerHealth.Location = new System.Drawing.Point(114, 27);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerHealth.TabIndex = 7;
            // 
            // lblPlayerAttack
            // 
            this.lblPlayerAttack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayerAttack.AutoSize = true;
            this.lblPlayerAttack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerAttack.Location = new System.Drawing.Point(114, 51);
            this.lblPlayerAttack.Name = "lblPlayerAttack";
            this.lblPlayerAttack.Size = new System.Drawing.Size(0, 17);
            this.lblPlayerAttack.TabIndex = 8;
            // 
            // lblEnemyDefence
            // 
            this.lblEnemyDefence.AutoSize = true;
            this.lblEnemyDefence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnemyDefence.Location = new System.Drawing.Point(114, 72);
            this.lblEnemyDefence.Name = "lblEnemyDefence";
            this.lblEnemyDefence.Size = new System.Drawing.Size(0, 17);
            this.lblEnemyDefence.TabIndex = 14;
            // 
            // lblEnemyAttack
            // 
            this.lblEnemyAttack.AutoSize = true;
            this.lblEnemyAttack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnemyAttack.Location = new System.Drawing.Point(114, 48);
            this.lblEnemyAttack.Name = "lblEnemyAttack";
            this.lblEnemyAttack.Size = new System.Drawing.Size(0, 17);
            this.lblEnemyAttack.TabIndex = 13;
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.ForeColor = System.Drawing.Color.Red;
            this.lblEnemyHealth.Location = new System.Drawing.Point(114, 24);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(0, 17);
            this.lblEnemyHealth.TabIndex = 12;
            // 
            // lblEnemyRace
            // 
            this.lblEnemyRace.AutoSize = true;
            this.lblEnemyRace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnemyRace.Location = new System.Drawing.Point(114, 0);
            this.lblEnemyRace.Name = "lblEnemyRace";
            this.lblEnemyRace.Size = new System.Drawing.Size(0, 17);
            this.lblEnemyRace.TabIndex = 11;
            // 
            // lblEnemy
            // 
            this.lblEnemy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.ForeColor = System.Drawing.Color.Black;
            this.lblEnemy.Location = new System.Drawing.Point(89, 7);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(55, 17);
            this.lblEnemy.TabIndex = 10;
            this.lblEnemy.Text = "Enemy:";
            // 
            // LblPlayerDefenceInfo
            // 
            this.LblPlayerDefenceInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPlayerDefenceInfo.AutoSize = true;
            this.LblPlayerDefenceInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPlayerDefenceInfo.Location = new System.Drawing.Point(43, 76);
            this.LblPlayerDefenceInfo.Name = "LblPlayerDefenceInfo";
            this.LblPlayerDefenceInfo.Size = new System.Drawing.Size(65, 17);
            this.LblPlayerDefenceInfo.TabIndex = 18;
            this.LblPlayerDefenceInfo.Text = "Defence:";
            // 
            // LblPlayerAttackInfo
            // 
            this.LblPlayerAttackInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPlayerAttackInfo.AutoSize = true;
            this.LblPlayerAttackInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPlayerAttackInfo.Location = new System.Drawing.Point(57, 51);
            this.LblPlayerAttackInfo.Name = "LblPlayerAttackInfo";
            this.LblPlayerAttackInfo.Size = new System.Drawing.Size(51, 17);
            this.LblPlayerAttackInfo.TabIndex = 17;
            this.LblPlayerAttackInfo.Text = "Attack:";
            // 
            // LblPlayerHealthInfo
            // 
            this.LblPlayerHealthInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPlayerHealthInfo.AutoSize = true;
            this.LblPlayerHealthInfo.ForeColor = System.Drawing.Color.Red;
            this.LblPlayerHealthInfo.Location = new System.Drawing.Point(55, 27);
            this.LblPlayerHealthInfo.Name = "LblPlayerHealthInfo";
            this.LblPlayerHealthInfo.Size = new System.Drawing.Size(53, 17);
            this.LblPlayerHealthInfo.TabIndex = 16;
            this.LblPlayerHealthInfo.Text = "Health:";
            // 
            // LblPlayerRaceInfo
            // 
            this.LblPlayerRaceInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblPlayerRaceInfo.AutoSize = true;
            this.LblPlayerRaceInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPlayerRaceInfo.Location = new System.Drawing.Point(68, 3);
            this.LblPlayerRaceInfo.Name = "LblPlayerRaceInfo";
            this.LblPlayerRaceInfo.Size = new System.Drawing.Size(40, 17);
            this.LblPlayerRaceInfo.TabIndex = 15;
            this.LblPlayerRaceInfo.Text = "Kind:";
            // 
            // LblEnemyDefenceInfo
            // 
            this.LblEnemyDefenceInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblEnemyDefenceInfo.AutoSize = true;
            this.LblEnemyDefenceInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEnemyDefenceInfo.Location = new System.Drawing.Point(43, 76);
            this.LblEnemyDefenceInfo.Name = "LblEnemyDefenceInfo";
            this.LblEnemyDefenceInfo.Size = new System.Drawing.Size(65, 17);
            this.LblEnemyDefenceInfo.TabIndex = 22;
            this.LblEnemyDefenceInfo.Text = "Defence:";
            // 
            // LblEnemyAttackInfo
            // 
            this.LblEnemyAttackInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblEnemyAttackInfo.AutoSize = true;
            this.LblEnemyAttackInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEnemyAttackInfo.Location = new System.Drawing.Point(57, 51);
            this.LblEnemyAttackInfo.Name = "LblEnemyAttackInfo";
            this.LblEnemyAttackInfo.Size = new System.Drawing.Size(51, 17);
            this.LblEnemyAttackInfo.TabIndex = 21;
            this.LblEnemyAttackInfo.Text = "Attack:";
            // 
            // LblEnemyHealthInfo
            // 
            this.LblEnemyHealthInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblEnemyHealthInfo.AutoSize = true;
            this.LblEnemyHealthInfo.ForeColor = System.Drawing.Color.Red;
            this.LblEnemyHealthInfo.Location = new System.Drawing.Point(55, 27);
            this.LblEnemyHealthInfo.Name = "LblEnemyHealthInfo";
            this.LblEnemyHealthInfo.Size = new System.Drawing.Size(53, 17);
            this.LblEnemyHealthInfo.TabIndex = 20;
            this.LblEnemyHealthInfo.Text = "Health:";
            // 
            // LblEnemyRaceInfo
            // 
            this.LblEnemyRaceInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblEnemyRaceInfo.AutoSize = true;
            this.LblEnemyRaceInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEnemyRaceInfo.Location = new System.Drawing.Point(68, 3);
            this.LblEnemyRaceInfo.Name = "LblEnemyRaceInfo";
            this.LblEnemyRaceInfo.Size = new System.Drawing.Size(40, 17);
            this.LblEnemyRaceInfo.TabIndex = 19;
            this.LblEnemyRaceInfo.Text = "Kind:";
            // 
            // timerBattle
            // 
            this.timerBattle.Enabled = true;
            this.timerBattle.Interval = 1800;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // TblPlayerInformation
            // 
            this.TblPlayerInformation.BackColor = System.Drawing.Color.Transparent;
            this.TblPlayerInformation.BackgroundImage = global::Game.Properties.Resources.BfnUa;
            this.TblPlayerInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TblPlayerInformation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TblPlayerInformation.ColumnCount = 1;
            this.TblPlayerInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPlayerInformation.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.TblPlayerInformation.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.TblPlayerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TblPlayerInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TblPlayerInformation.Location = new System.Drawing.Point(21, 18);
            this.TblPlayerInformation.Name = "TblPlayerInformation";
            this.TblPlayerInformation.RowCount = 2;
            this.TblPlayerInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblPlayerInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TblPlayerInformation.Size = new System.Drawing.Size(234, 139);
            this.TblPlayerInformation.TabIndex = 28;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblPlayer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 20);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerAttack, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.LblPlayerAttackInfo, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.LblPlayerRaceInfo, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.LblPlayerHealthInfo, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.LblPlayerDefenceInfo, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerHealth, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerRace, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblPlayerDefence, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(222, 98);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblPlayerRace
            // 
            this.lblPlayerRace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayerRace.AutoSize = true;
            this.lblPlayerRace.Location = new System.Drawing.Point(114, 3);
            this.lblPlayerRace.Name = "lblPlayerRace";
            this.lblPlayerRace.Size = new System.Drawing.Size(46, 17);
            this.lblPlayerRace.TabIndex = 19;
            this.lblPlayerRace.Text = "label1";
            // 
            // lblPlayerDefence
            // 
            this.lblPlayerDefence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlayerDefence.AutoSize = true;
            this.lblPlayerDefence.Location = new System.Drawing.Point(114, 76);
            this.lblPlayerDefence.Name = "lblPlayerDefence";
            this.lblPlayerDefence.Size = new System.Drawing.Size(46, 17);
            this.lblPlayerDefence.TabIndex = 20;
            this.lblPlayerDefence.Text = "label2";
            // 
            // TblEnemyInformation
            // 
            this.TblEnemyInformation.BackColor = System.Drawing.Color.Transparent;
            this.TblEnemyInformation.BackgroundImage = global::Game.Properties.Resources.BfnUa;
            this.TblEnemyInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TblEnemyInformation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TblEnemyInformation.ColumnCount = 1;
            this.TblEnemyInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblEnemyInformation.Controls.Add(this.lblEnemy, 0, 0);
            this.TblEnemyInformation.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.TblEnemyInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TblEnemyInformation.ForeColor = System.Drawing.Color.Black;
            this.TblEnemyInformation.Location = new System.Drawing.Point(538, 18);
            this.TblEnemyInformation.Name = "TblEnemyInformation";
            this.TblEnemyInformation.RowCount = 2;
            this.TblEnemyInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TblEnemyInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TblEnemyInformation.Size = new System.Drawing.Size(234, 139);
            this.TblEnemyInformation.TabIndex = 29;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblEnemyRace, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.LblEnemyRaceInfo, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblEnemyHealth, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.LblEnemyAttackInfo, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblEnemyDefence, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.LblEnemyHealthInfo, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblEnemyAttack, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.LblEnemyDefenceInfo, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 35);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(222, 98);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // TblCounting
            // 
            this.TblCounting.BackColor = System.Drawing.Color.Transparent;
            this.TblCounting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TblCounting.ColumnCount = 1;
            this.TblCounting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblCounting.Location = new System.Drawing.Point(277, 18);
            this.TblCounting.Name = "TblCounting";
            this.TblCounting.RowCount = 1;
            this.TblCounting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblCounting.Size = new System.Drawing.Size(230, 100);
            this.TblCounting.TabIndex = 30;
            // 
            // TblTurns
            // 
            this.TblTurns.BackColor = System.Drawing.Color.Transparent;
            this.TblTurns.ColumnCount = 2;
            this.TblTurns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblTurns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.TblTurns.Controls.Add(this.PicBoxTurn, 0, 0);
            this.TblTurns.Controls.Add(this.LblTurnNumber, 1, 0);
            this.TblTurns.Location = new System.Drawing.Point(294, 124);
            this.TblTurns.Name = "TblTurns";
            this.TblTurns.RowCount = 1;
            this.TblTurns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblTurns.Size = new System.Drawing.Size(229, 70);
            this.TblTurns.TabIndex = 31;
            this.TblTurns.Visible = false;
            // 
            // PicBoxTurn
            // 
            this.PicBoxTurn.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxTurn.BackgroundImage = global::Game.Properties.Resources.TurnImage;
            this.PicBoxTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBoxTurn.Location = new System.Drawing.Point(3, 3);
            this.PicBoxTurn.Name = "PicBoxTurn";
            this.PicBoxTurn.Size = new System.Drawing.Size(118, 64);
            this.PicBoxTurn.TabIndex = 0;
            this.PicBoxTurn.TabStop = false;
            // 
            // LblTurnNumber
            // 
            this.LblTurnNumber.AutoSize = true;
            this.LblTurnNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTurnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTurnNumber.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblTurnNumber.Location = new System.Drawing.Point(127, 0);
            this.LblTurnNumber.Name = "LblTurnNumber";
            this.LblTurnNumber.Size = new System.Drawing.Size(99, 70);
            this.LblTurnNumber.TabIndex = 1;
            this.LblTurnNumber.Text = "1";
            this.LblTurnNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TblPlayerMinusHealth
            // 
            this.TblPlayerMinusHealth.BackColor = System.Drawing.Color.Transparent;
            this.TblPlayerMinusHealth.ColumnCount = 2;
            this.TblPlayerMinusHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.4413F));
            this.TblPlayerMinusHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.5587F));
            this.TblPlayerMinusHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblPlayerMinusHealth.Controls.Add(this.pictureBox1, 1, 0);
            this.TblPlayerMinusHealth.Controls.Add(this.LblPlayerMinusHealh, 0, 0);
            this.TblPlayerMinusHealth.Location = new System.Drawing.Point(2, 163);
            this.TblPlayerMinusHealth.Name = "TblPlayerMinusHealth";
            this.TblPlayerMinusHealth.RowCount = 1;
            this.TblPlayerMinusHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPlayerMinusHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TblPlayerMinusHealth.Size = new System.Drawing.Size(247, 55);
            this.TblPlayerMinusHealth.TabIndex = 32;
            this.TblPlayerMinusHealth.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Game.Properties.Resources.WordHealth;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(135, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblPlayerMinusHealh
            // 
            this.LblPlayerMinusHealh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPlayerMinusHealh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPlayerMinusHealh.ForeColor = System.Drawing.Color.Red;
            this.LblPlayerMinusHealh.Location = new System.Drawing.Point(3, 0);
            this.LblPlayerMinusHealh.Name = "LblPlayerMinusHealh";
            this.LblPlayerMinusHealh.Size = new System.Drawing.Size(126, 55);
            this.LblPlayerMinusHealh.TabIndex = 1;
            this.LblPlayerMinusHealh.Text = "-59";
            this.LblPlayerMinusHealh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TblEnemyMinusHealth
            // 
            this.TblEnemyMinusHealth.BackColor = System.Drawing.Color.Transparent;
            this.TblEnemyMinusHealth.ColumnCount = 2;
            this.TblEnemyMinusHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.26772F));
            this.TblEnemyMinusHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.73228F));
            this.TblEnemyMinusHealth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblEnemyMinusHealth.Controls.Add(this.pictureBox2, 1, 0);
            this.TblEnemyMinusHealth.Controls.Add(this.LblEnemyMinusHealth, 0, 0);
            this.TblEnemyMinusHealth.Location = new System.Drawing.Point(500, 163);
            this.TblEnemyMinusHealth.Name = "TblEnemyMinusHealth";
            this.TblEnemyMinusHealth.RowCount = 1;
            this.TblEnemyMinusHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblEnemyMinusHealth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.TblEnemyMinusHealth.Size = new System.Drawing.Size(254, 55);
            this.TblEnemyMinusHealth.TabIndex = 33;
            this.TblEnemyMinusHealth.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Game.Properties.Resources.WordHealth;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(151, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 49);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // LblEnemyMinusHealth
            // 
            this.LblEnemyMinusHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblEnemyMinusHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblEnemyMinusHealth.ForeColor = System.Drawing.Color.Red;
            this.LblEnemyMinusHealth.Location = new System.Drawing.Point(3, 0);
            this.LblEnemyMinusHealth.Name = "LblEnemyMinusHealth";
            this.LblEnemyMinusHealth.Size = new System.Drawing.Size(142, 55);
            this.LblEnemyMinusHealth.TabIndex = 1;
            this.LblEnemyMinusHealth.Text = "-59";
            this.LblEnemyMinusHealth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBattleInformation
            // 
            this.lblBattleInformation.AutoSize = true;
            this.lblBattleInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblBattleInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBattleInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBattleInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBattleInformation.Location = new System.Drawing.Point(3, 0);
            this.lblBattleInformation.Name = "lblBattleInformation";
            this.lblBattleInformation.Size = new System.Drawing.Size(352, 37);
            this.lblBattleInformation.TabIndex = 34;
            this.lblBattleInformation.Text = "Info";
            this.lblBattleInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::Game.Properties.Resources.BfnUa;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblBattleInformation, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(219, 221);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 37);
            this.tableLayoutPanel1.TabIndex = 35;
            this.tableLayoutPanel1.Visible = false;
            // 
            // BattleTownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Castle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TblEnemyMinusHealth);
            this.Controls.Add(this.TblPlayerMinusHealth);
            this.Controls.Add(this.TblTurns);
            this.Controls.Add(this.TblCounting);
            this.Controls.Add(this.TblEnemyInformation);
            this.Controls.Add(this.TblPlayerInformation);
            this.Controls.Add(this.PicBoxVS);
            this.Controls.Add(this.pictBoxEnemy);
            this.Controls.Add(this.pictBoxPlayer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BattleTownForm";
            this.Text = "Town";
            this.Load += new System.EventHandler(this.TownForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxVS)).EndInit();
            this.TblPlayerInformation.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.TblEnemyInformation.ResumeLayout(false);
            this.TblEnemyInformation.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.TblTurns.ResumeLayout(false);
            this.TblTurns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxTurn)).EndInit();
            this.TblPlayerMinusHealth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TblEnemyMinusHealth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxPlayer;
        private System.Windows.Forms.PictureBox pictBoxEnemy;
        private System.Windows.Forms.PictureBox PicBoxVS;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblPlayerAttack;
        private System.Windows.Forms.Label lblEnemyDefence;
        private System.Windows.Forms.Label lblEnemyAttack;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label lblEnemyRace;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Label LblPlayerDefenceInfo;
        private System.Windows.Forms.Label LblPlayerAttackInfo;
        private System.Windows.Forms.Label LblPlayerHealthInfo;
        private System.Windows.Forms.Label LblPlayerRaceInfo;
        private System.Windows.Forms.Label LblEnemyDefenceInfo;
        private System.Windows.Forms.Label LblEnemyAttackInfo;
        private System.Windows.Forms.Label LblEnemyHealthInfo;
        private System.Windows.Forms.Label LblEnemyRaceInfo;
        private System.Windows.Forms.Timer timerBattle;
        private System.Windows.Forms.TableLayoutPanel TblPlayerInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblPlayerRace;
        private System.Windows.Forms.Label lblPlayerDefence;
        private System.Windows.Forms.TableLayoutPanel TblEnemyInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel TblCounting;
        private System.Windows.Forms.TableLayoutPanel TblTurns;
        private System.Windows.Forms.PictureBox PicBoxTurn;
        private System.Windows.Forms.Label LblTurnNumber;
        private System.Windows.Forms.TableLayoutPanel TblPlayerMinusHealth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblPlayerMinusHealh;
        private System.Windows.Forms.TableLayoutPanel TblEnemyMinusHealth;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblEnemyMinusHealth;
        private System.Windows.Forms.Label lblBattleInformation;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}