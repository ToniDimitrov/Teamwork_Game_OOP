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
        public CreatePlayer()
        {
            InitializeComponent();
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
    }
}
