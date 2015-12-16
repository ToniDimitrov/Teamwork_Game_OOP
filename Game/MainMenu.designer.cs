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
            this.GameName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewGame = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.Location = new System.Drawing.Point(236, 28);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(329, 53);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Name goes here";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.NewGame);
            this.flowLayoutPanel1.Controls.Add(this.Options);
            this.flowLayoutPanel1.Controls.Add(this.Exit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(303, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(191, 176);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(3, 3);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(180, 50);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Options
            // 
            this.Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Options.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Options.Location = new System.Drawing.Point(3, 59);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(180, 50);
            this.Options.TabIndex = 2;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(3, 115);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 50);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GameName);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Exit;
    }
}