using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            CreatePlayer newPlayer=new CreatePlayer();
            newPlayer.Sender = this;
            newPlayer.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
