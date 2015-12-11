using System;

namespace Game.Models
{
    public struct Size
    {
        private int height;
        private int width;

        public Size(int height, int width)
            : this()
        {
            this.Height = height;
            this.Width = width;
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive");
                }
                this.height = value;
            }
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be positive");
                }
                this.width = value;
            }
        }
    }
}