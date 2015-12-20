using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Models;

namespace Game
{
    public partial class CreatePlayer : Form
    {
        private Image SpartanImage;
        private Image VikingImage;
        private Image BarbarianImage;

        public CreatePlayer()
        {
            InitializeComponent();
            SpartanImage = SpartanButton.BackgroundImage;
            VikingImage = VikingButton.BackgroundImage;
            BarbarianImage = BarbarianButton.BackgroundImage;
        }
        public MainMenu Sender { get; set; }

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

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Game newGame=new Game();
            string playerName = this.textBoxName.Text;
            if (string.IsNullOrEmpty(playerName) || string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Player name cannot be empty");
                return;
            }
            string playerType = string.Empty;
            if (SpartanButton.Checked)
            {
                playerType += "Spartan";
            }
            else if (VikingButton.Checked)
            {
                playerType += "Viking";
            }
            else if (BarbarianButton.Checked)
            {
                playerType += "Barbarian";
            }
            else
            {
                MessageBox.Show("You have to choose a hero type before you start a game.");
                return;
            }
            newGame.CreatePlayer(playerName,playerType);
            newGame.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Sender.Show();
            this.Hide();
        }

        private void SpartanButton_MouseEnter(object sender, EventArgs e)
        {
            SpartanImage = SpartanButton.BackgroundImage;

            string pathImage = "Buttons/SpartanButton3.png";
            SpartanButton.BackgroundImage=Image.FromFile(pathImage);
        }

        private void SpartanButton_MouseLeave(object sender, EventArgs e)
        {
            if (SpartanButton.Checked)
            {
                SpartanButton.BackgroundImage=Image.FromFile("Buttons/SpartanButton.png");
            }
            else
            {
                SpartanButton.BackgroundImage = SpartanImage;
            }
        }

        private void BarbarianButton_MouseEnter(object sender, EventArgs e)
        {
            BarbarianImage = BarbarianButton.BackgroundImage;

            string pathImage = "Buttons/BarbarianButton3.png";
            BarbarianButton.BackgroundImage = Image.FromFile(pathImage);
        }

        private void BarbarianButton_MouseLeave(object sender, EventArgs e)
        {
            if (BarbarianButton.Checked)
            {
                BarbarianButton.BackgroundImage = Image.FromFile("Buttons/BarbarianButton.png");
            }
            else
            {
                BarbarianButton.BackgroundImage = BarbarianImage;
            }
        }

        private void VikingButton_MouseEnter(object sender, EventArgs e)
        {
            VikingImage = VikingButton.BackgroundImage;

            string pathImage = "Buttons/VikingButton3.png";
            VikingButton.BackgroundImage = Image.FromFile(pathImage);
        }

        private void VikingButton_MouseLeave(object sender, EventArgs e)
        {
            if (VikingButton.Checked)
            {
                VikingButton.BackgroundImage = Image.FromFile("Buttons/VikingButton.png");
            }
            else
            {
                VikingButton.BackgroundImage = VikingImage;
            }
        }

        private void SpartanButton_MouseClick(object sender, MouseEventArgs e)
        {
            string pathImage1 = "Buttons/BarbarianButton2.png";
            string pathImage2 = "Buttons/VikingButton2.png";

            string pathImage = "Buttons/SpartanButton.png";
            SpartanButton.BackgroundImage = Image.FromFile(pathImage);

            BarbarianButton.BackgroundImage = Image.FromFile(pathImage1);
            VikingButton.BackgroundImage = Image.FromFile(pathImage2);
        }

        private void VikingButton_MouseClick(object sender, MouseEventArgs e)
        {
            string pathImage1 = "Buttons/BarbarianButton2.png";
            string pathImage2 = "Buttons/SpartanButton2.png";

            string pathImage = "Buttons/VikingButton.png";
            VikingButton.BackgroundImage = Image.FromFile(pathImage);

            BarbarianButton.BackgroundImage = Image.FromFile(pathImage1);
            SpartanButton.BackgroundImage = Image.FromFile(pathImage2);
        }

        private void BarbarianButton_MouseClick(object sender, MouseEventArgs e)
        {
            string pathImage1 = "Buttons/VikingButton2.png";
            string pathImage2 = "Buttons/SpartanButton2.png";

            string pathImage = "Buttons/BarbarianButton.png";
            BarbarianButton.BackgroundImage = Image.FromFile(pathImage);

            VikingButton.BackgroundImage = Image.FromFile(pathImage1);
            SpartanButton.BackgroundImage = Image.FromFile(pathImage2);
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Transparent;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }
    }
}
