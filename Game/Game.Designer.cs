using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.Map = new System.Windows.Forms.PictureBox();
            this.UnderMapWithInpassableAreas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderMapWithInpassableAreas)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMovement
            // 
            this.timerMovement.Enabled = true;
            this.timerMovement.Interval = 5;
            this.timerMovement.Tick += new System.EventHandler(this.timerMovement_Tick);
            // 
            // Map
            // 
            this.Map.Image = ((System.Drawing.Image)(resources.GetObject("Map.Image")));
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(2048, 2039);
            this.Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Map.TabIndex = 0;
            this.Map.TabStop = false;
            // 
            // UnderMapWithInpassableAreas
            // 
            this.UnderMapWithInpassableAreas.Image = ((System.Drawing.Image)(resources.GetObject("UnderMapWithInpassableAreas.Image")));
            this.UnderMapWithInpassableAreas.Location = new System.Drawing.Point(0, 0);
            this.UnderMapWithInpassableAreas.Name = "UnderMapWithInpassableAreas";
            this.UnderMapWithInpassableAreas.Size = new System.Drawing.Size(2048, 2039);
            this.UnderMapWithInpassableAreas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UnderMapWithInpassableAreas.TabIndex = 1;
            this.UnderMapWithInpassableAreas.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(982, 606);
            this.Controls.Add(this.UnderMapWithInpassableAreas);
            this.Controls.Add(this.Map);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderMapWithInpassableAreas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMovement;
        private System.Windows.Forms.PictureBox Map;
        public PictureBox UnderMapWithInpassableAreas;
    }
}

