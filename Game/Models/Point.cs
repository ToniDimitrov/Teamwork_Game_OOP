using System;

namespace Game.Models
{
    public struct Point
    {
        private int x;
        private int y;

        public Point(int x, int y) : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get { return x; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The x coordinate must be within the screen");
                }
                x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The y coordinate must be within the screen");
                }
                y = value;
            }
        }
    }
}