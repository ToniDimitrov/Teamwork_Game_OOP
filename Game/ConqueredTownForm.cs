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
    public partial class ConqueredTownForm : Form
    {
        private Image image;

        public ConqueredTownForm(Timer sendTimer) //Image imageTown)
        {
            InitializeComponent();
            this.SenderTimer = sendTimer;
            //this.image = imageTown;
        }


        public Timer SenderTimer { get; set; }

        private void ConquredTownForm_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.Image = image;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.SenderTimer.Start();
        }

    }
}
