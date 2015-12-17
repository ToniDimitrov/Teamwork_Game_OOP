namespace Game
{
    partial class CreatePlayer
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
            this.Title = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.GetNameTable = new System.Windows.Forms.TableLayoutPanel();
            this.LblHeroName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.LblChooseType = new System.Windows.Forms.Label();
            this.GetTypeTable = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BarbarianButton = new System.Windows.Forms.RadioButton();
            this.SpartanButton = new System.Windows.Forms.RadioButton();
            this.VikingButton = new System.Windows.Forms.RadioButton();
            this.GetNameTable.SuspendLayout();
            this.GetTypeTable.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Adobe Hebrew", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Image = global::Game.Properties.Resources.BfnUa;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Title.Location = new System.Drawing.Point(294, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(216, 34);
            this.Title.TabIndex = 0;
            this.Title.Text = "Create Your Hero";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::Game.Properties.Resources.Button_Background;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 514);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(120, 40);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.BackgroundImage = global::Game.Properties.Resources.Button_Background;
            this.StartGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameButton.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.Location = new System.Drawing.Point(652, 514);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(120, 40);
            this.StartGameButton.TabIndex = 4;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // GetNameTable
            // 
            this.GetNameTable.AutoScroll = true;
            this.GetNameTable.BackColor = System.Drawing.Color.Transparent;
            this.GetNameTable.BackgroundImage = global::Game.Properties.Resources.BfnUa;
            this.GetNameTable.ColumnCount = 1;
            this.GetNameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GetNameTable.Controls.Add(this.LblHeroName, 0, 0);
            this.GetNameTable.Controls.Add(this.textBoxName, 0, 1);
            this.GetNameTable.Location = new System.Drawing.Point(254, 62);
            this.GetNameTable.Name = "GetNameTable";
            this.GetNameTable.RowCount = 2;
            this.GetNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GetNameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.GetNameTable.Size = new System.Drawing.Size(288, 85);
            this.GetNameTable.TabIndex = 5;
            // 
            // LblHeroName
            // 
            this.LblHeroName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblHeroName.AutoSize = true;
            this.LblHeroName.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeroName.Location = new System.Drawing.Point(81, 0);
            this.LblHeroName.Name = "LblHeroName";
            this.LblHeroName.Size = new System.Drawing.Size(125, 26);
            this.LblHeroName.TabIndex = 0;
            this.LblHeroName.Text = "Player Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(47, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(194, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // LblChooseType
            // 
            this.LblChooseType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblChooseType.AutoSize = true;
            this.LblChooseType.Font = new System.Drawing.Font("Adobe Hebrew", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChooseType.Location = new System.Drawing.Point(226, 4);
            this.LblChooseType.Name = "LblChooseType";
            this.LblChooseType.Size = new System.Drawing.Size(188, 26);
            this.LblChooseType.TabIndex = 0;
            this.LblChooseType.Text = "Choose Player Type";
            // 
            // GetTypeTable
            // 
            this.GetTypeTable.BackColor = System.Drawing.Color.Transparent;
            this.GetTypeTable.BackgroundImage = global::Game.Properties.Resources.BfnUa;
            this.GetTypeTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GetTypeTable.ColumnCount = 1;
            this.GetTypeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GetTypeTable.Controls.Add(this.LblChooseType, 0, 0);
            this.GetTypeTable.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.GetTypeTable.Location = new System.Drawing.Point(82, 153);
            this.GetTypeTable.Name = "GetTypeTable";
            this.GetTypeTable.RowCount = 2;
            this.GetTypeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.GetTypeTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.GetTypeTable.Size = new System.Drawing.Size(641, 355);
            this.GetTypeTable.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BarbarianButton);
            this.flowLayoutPanel1.Controls.Add(this.SpartanButton);
            this.flowLayoutPanel1.Controls.Add(this.VikingButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(635, 314);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BarbarianButton
            // 
            this.BarbarianButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarbarianButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.BarbarianButton.BackgroundImage = global::Game.Properties.Resources.BarbarianButton;
            this.BarbarianButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarbarianButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarbarianButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.BarbarianButton.FlatAppearance.BorderSize = 0;
            this.BarbarianButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.BarbarianButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BarbarianButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BarbarianButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarbarianButton.Location = new System.Drawing.Point(3, 3);
            this.BarbarianButton.Name = "BarbarianButton";
            this.BarbarianButton.Size = new System.Drawing.Size(203, 262);
            this.BarbarianButton.TabIndex = 0;
            this.BarbarianButton.TabStop = true;
            this.BarbarianButton.UseVisualStyleBackColor = true;
            this.BarbarianButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BarbarianButton_MouseClick);
            this.BarbarianButton.MouseEnter += new System.EventHandler(this.BarbarianButton_MouseEnter);
            this.BarbarianButton.MouseLeave += new System.EventHandler(this.BarbarianButton_MouseLeave);
            // 
            // SpartanButton
            // 
            this.SpartanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpartanButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.SpartanButton.BackgroundImage = global::Game.Properties.Resources.SpartanButton;
            this.SpartanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpartanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SpartanButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.SpartanButton.FlatAppearance.BorderSize = 0;
            this.SpartanButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SpartanButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SpartanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SpartanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpartanButton.Location = new System.Drawing.Point(212, 3);
            this.SpartanButton.Name = "SpartanButton";
            this.SpartanButton.Size = new System.Drawing.Size(203, 262);
            this.SpartanButton.TabIndex = 1;
            this.SpartanButton.TabStop = true;
            this.SpartanButton.UseVisualStyleBackColor = true;
            this.SpartanButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SpartanButton_MouseClick);
            this.SpartanButton.MouseEnter += new System.EventHandler(this.SpartanButton_MouseEnter);
            this.SpartanButton.MouseLeave += new System.EventHandler(this.SpartanButton_MouseLeave);
            // 
            // VikingButton
            // 
            this.VikingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VikingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.VikingButton.BackgroundImage = global::Game.Properties.Resources.VikingButton;
            this.VikingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VikingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VikingButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.VikingButton.FlatAppearance.BorderSize = 0;
            this.VikingButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.VikingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VikingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VikingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VikingButton.Location = new System.Drawing.Point(421, 3);
            this.VikingButton.Name = "VikingButton";
            this.VikingButton.Size = new System.Drawing.Size(203, 262);
            this.VikingButton.TabIndex = 2;
            this.VikingButton.TabStop = true;
            this.VikingButton.UseVisualStyleBackColor = true;
            this.VikingButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VikingButton_MouseClick);
            this.VikingButton.MouseEnter += new System.EventHandler(this.VikingButton_MouseEnter);
            this.VikingButton.MouseLeave += new System.EventHandler(this.VikingButton_MouseLeave);
            // 
            // CreatePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 576);
            this.Controls.Add(this.GetTypeTable);
            this.Controls.Add(this.GetNameTable);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Title);
            this.Name = "CreatePlayer";
            this.Text = "Create Player";
            this.GetNameTable.ResumeLayout(false);
            this.GetNameTable.PerformLayout();
            this.GetTypeTable.ResumeLayout(false);
            this.GetTypeTable.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BackButton;
        internal System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.TableLayoutPanel GetNameTable;
        private System.Windows.Forms.Label LblHeroName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label LblChooseType;
        private System.Windows.Forms.TableLayoutPanel GetTypeTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton VikingButton;
        private System.Windows.Forms.RadioButton BarbarianButton;
        private System.Windows.Forms.RadioButton SpartanButton;
    }
}