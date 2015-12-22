namespace Game
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.GameName = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BluringTimer = new System.Windows.Forms.Timer(this.components);
            this.BluringPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BluringPicture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoEllipsis = true;
            this.GameName.BackColor = System.Drawing.Color.Transparent;
            this.GameName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameName.Font = new System.Drawing.Font("Adobe Devanagari", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.Black;
            this.GameName.Image = global::Game.Properties.Resources.tumblr_inline_mt4ng7J4wZ1rydp4g;
            this.GameName.Location = new System.Drawing.Point(182, 42);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(432, 77);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Conqueror";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameName.UseCompatibleTextRendering = true;
            // 
            // NewGame
            // 
            this.NewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewGame.BackgroundImage = global::Game.Properties.Resources.Button_Background;
            this.NewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewGame.FlatAppearance.BorderSize = 0;
            this.NewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame.Font = new System.Drawing.Font("Lithos Pro Regular", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NewGame.Location = new System.Drawing.Point(58, 29);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(250, 80);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            this.NewGame.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.NewGame.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // Options
            // 
            this.Options.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Options.BackgroundImage = global::Game.Properties.Resources.Button_Background;
            this.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Options.FlatAppearance.BorderSize = 0;
            this.Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Lithos Pro Regular", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(58, 160);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(250, 80);
            this.Options.TabIndex = 2;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            this.Options.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.Options.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackgroundImage = global::Game.Properties.Resources.Button_Background;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Lithos Pro Regular", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(58, 285);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(250, 80);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.NewGame_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.NewGame_MouseLeave);
            // 
            // BluringTimer
            // 
            this.BluringTimer.Enabled = true;
            this.BluringTimer.Interval = 33;
            this.BluringTimer.Tick += new System.EventHandler(this.BluringTimer_Tick);
            // 
            // BluringPicture
            // 
            this.BluringPicture.Location = new System.Drawing.Point(52, 303);
            this.BluringPicture.Name = "BluringPicture";
            this.BluringPicture.Size = new System.Drawing.Size(100, 50);
            this.BluringPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluringPicture.TabIndex = 2;
            this.BluringPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = global::Game.Properties.Resources.BfnUa;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.NewGame, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Options, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Exit, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(212, 155);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.65659F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.17171F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.17171F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 388);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::Game.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 576);
            this.Controls.Add(this.BluringPicture);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.BluringPicture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer BluringTimer;
        private System.Windows.Forms.PictureBox BluringPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}