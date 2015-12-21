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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPlayerRace = new System.Windows.Forms.Label();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayerDefence = new System.Windows.Forms.Label();
            this.lblPlayerAttack = new System.Windows.Forms.Label();
            this.lblEnemyDefence = new System.Windows.Forms.Label();
            this.lblEnemyAttack = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblEnemyRace = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBattleInformation = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.timerBattle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxPlayer
            // 
            this.pictBoxPlayer.Location = new System.Drawing.Point(0, 194);
            this.pictBoxPlayer.Name = "pictBoxPlayer";
            this.pictBoxPlayer.Size = new System.Drawing.Size(161, 153);
            this.pictBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxPlayer.TabIndex = 1;
            this.pictBoxPlayer.TabStop = false;
            // 
            // pictBoxEnemy
            // 
            this.pictBoxEnemy.Location = new System.Drawing.Point(271, 194);
            this.pictBoxEnemy.Name = "pictBoxEnemy";
            this.pictBoxEnemy.Size = new System.Drawing.Size(161, 153);
            this.pictBoxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxEnemy.TabIndex = 2;
            this.pictBoxEnemy.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(192, 253);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(40, 13);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Player:";
            // 
            // lblPlayerRace
            // 
            this.lblPlayerRace.AutoSize = true;
            this.lblPlayerRace.Location = new System.Drawing.Point(92, 30);
            this.lblPlayerRace.Name = "lblPlayerRace";
            this.lblPlayerRace.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerRace.TabIndex = 6;
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(92, 43);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerHealth.TabIndex = 7;
            // 
            // lblPlayerDefence
            // 
            this.lblPlayerDefence.AutoSize = true;
            this.lblPlayerDefence.Location = new System.Drawing.Point(92, 69);
            this.lblPlayerDefence.Name = "lblPlayerDefence";
            this.lblPlayerDefence.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerDefence.TabIndex = 9;
            // 
            // lblPlayerAttack
            // 
            this.lblPlayerAttack.AutoSize = true;
            this.lblPlayerAttack.Location = new System.Drawing.Point(92, 56);
            this.lblPlayerAttack.Name = "lblPlayerAttack";
            this.lblPlayerAttack.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerAttack.TabIndex = 8;
            // 
            // lblEnemyDefence
            // 
            this.lblEnemyDefence.AutoSize = true;
            this.lblEnemyDefence.Location = new System.Drawing.Point(361, 69);
            this.lblEnemyDefence.Name = "lblEnemyDefence";
            this.lblEnemyDefence.Size = new System.Drawing.Size(0, 13);
            this.lblEnemyDefence.TabIndex = 14;
            // 
            // lblEnemyAttack
            // 
            this.lblEnemyAttack.AutoSize = true;
            this.lblEnemyAttack.Location = new System.Drawing.Point(361, 56);
            this.lblEnemyAttack.Name = "lblEnemyAttack";
            this.lblEnemyAttack.Size = new System.Drawing.Size(0, 13);
            this.lblEnemyAttack.TabIndex = 13;
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Location = new System.Drawing.Point(361, 43);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(0, 13);
            this.lblEnemyHealth.TabIndex = 12;
            // 
            // lblEnemyRace
            // 
            this.lblEnemyRace.AutoSize = true;
            this.lblEnemyRace.Location = new System.Drawing.Point(361, 30);
            this.lblEnemyRace.Name = "lblEnemyRace";
            this.lblEnemyRace.Size = new System.Drawing.Size(0, 13);
            this.lblEnemyRace.TabIndex = 11;
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(310, 13);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(42, 13);
            this.lblEnemy.TabIndex = 10;
            this.lblEnemy.Text = "Enemy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Defence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Attack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kind:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Defence:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Attack:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Health:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kind:";
            // 
            // lblBattleInformation
            // 
            this.lblBattleInformation.Font = new System.Drawing.Font("Calibri", 8.3F);
            this.lblBattleInformation.Location = new System.Drawing.Point(122, 132);
            this.lblBattleInformation.Name = "lblBattleInformation";
            this.lblBattleInformation.Size = new System.Drawing.Size(181, 59);
            this.lblBattleInformation.TabIndex = 23;
            this.lblBattleInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(192, 116);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 13);
            this.lblTurn.TabIndex = 24;
            // 
            // timerBattle
            // 
            this.timerBattle.Enabled = true;
            this.timerBattle.Interval = 1800;
            this.timerBattle.Tick += new System.EventHandler(this.timerBattle_Tick);
            // 
            // BattleTownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 347);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblBattleInformation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEnemyDefence);
            this.Controls.Add(this.lblEnemyAttack);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblEnemyRace);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblPlayerDefence);
            this.Controls.Add(this.lblPlayerAttack);
            this.Controls.Add(this.lblPlayerHealth);
            this.Controls.Add(this.lblPlayerRace);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictBoxEnemy);
            this.Controls.Add(this.pictBoxPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BattleTownForm";
            this.Text = "Town";
            this.Load += new System.EventHandler(this.TownForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxPlayer;
        private System.Windows.Forms.PictureBox pictBoxEnemy;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblPlayerRace;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblPlayerDefence;
        private System.Windows.Forms.Label lblPlayerAttack;
        private System.Windows.Forms.Label lblEnemyDefence;
        private System.Windows.Forms.Label lblEnemyAttack;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label lblEnemyRace;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBattleInformation;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Timer timerBattle;
    }
}