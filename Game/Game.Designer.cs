namespace Game
{
    partial class Game
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
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMovement
            // 
            this.timerMovement.Enabled = true;
            this.timerMovement.Interval = 1;
            this.timerMovement.Tick += new System.EventHandler(this.timerMovement_Tick);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::Game.Properties.Resources.map;
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.panel6);
            this.backgroundPanel.Controls.Add(this.panel5);
            this.backgroundPanel.Controls.Add(this.panel3);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(1362, 741);
            this.backgroundPanel.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(60, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(365, 36);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(237, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(57, 256);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 85);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(71, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 57);
            this.panel2.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.backgroundPanel);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.backgroundPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
    }
}

