using Game.Models;

namespace Game.Models
{
    public abstract class GameObject
    {
        //Мисля че трябва да има properties за тези полета

        protected GameObject(string id, Point location, Size objectSize)
        {
            this.Id = id;
            this.Location = location;
            this.ObjectSize = objectSize;
        }

        public string Id { get; private set; }

        public Point Location { get; set; }

        public Size ObjectSize { get; set; }
    }
}