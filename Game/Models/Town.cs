using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Game.Interfaces;
using Game.Models;

namespace Game.Models
{
    public class Town : GameObject
    {

        public Town(string id, Point location, Size objectSize, Hero enemyHero, bool isConquered)//, string pictureTownPath)
            : base(id, location, objectSize)
        {
            this.EnemyHero = enemyHero;
            this.IsConquered = isConquered;
            //InitPictureTown(pictureTownPath);
        }

        public PictureBox PictureTown { get; set; }

        //private void InitPictureTown(string path)
        //{
        //    this.PictureTown = new PictureBox
        //    {
        //        Image = Image.FromFile(path),
        //        Size = new System.Drawing.Size(this.ObjectSize.Width, this.ObjectSize.Height),
        //        Location = new System.Drawing.Point(this.Location.X, this.Location.Y),
        //        Enabled = true,
        //        Visible = true,
        //        SizeMode = PictureBoxSizeMode.StretchImage,
        //        BackColor = Color.Transparent
        //    };
        //}

        public Hero EnemyHero { get; set; }

        public bool IsConquered { get; set; }
    }
}