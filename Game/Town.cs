using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models;

namespace Game
{
    public partial class Town : Form
    {
        public Town(Timer sendTimer)
        {
            InitializeComponent();
            this.SenderTimer = sendTimer;
        }

        public Timer SenderTimer { get; set; }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.SenderTimer.Start();
        }
    }
}
