
namespace Map
{
    abstract class MapObject
    {
        protected char image;

        public char Image
        {
            get
            {
                return image;
            }
        }

        public MapObject(Behavior behavior)
        {
            this.behavior = behavior;
        }

        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        protected Behavior behavior;
    }
}
