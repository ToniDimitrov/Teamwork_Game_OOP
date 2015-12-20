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
        private int timerTicks = 30;
        public MainMenu()
        {
            InitializeComponent();
            BluringPicture.Dock=DockStyle.Fill;
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

        private void BluringTimer_Tick(object sender, EventArgs e)
        {
            if (timerTicks <= 0)
            {
                BluringTimer.Stop();
                BluringPicture.Visible = false;
                return;
            }
            string pathImage = "Bluring/" + timerTicks.ToString() + ".jpg";
            BluringPicture.Image=Image.FromFile(pathImage);
            timerTicks--;
        }

        private void Options_Click(object sender, EventArgs e)
        {

        }

        private void NewGame_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Transparent;
        }

        private void NewGame_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor=Color.Black;
        }
    }
}
