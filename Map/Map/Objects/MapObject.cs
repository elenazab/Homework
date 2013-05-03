
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

        public Decision MakeMove(Map map)
        {
            return behavior.Think();
        }

        public MapObject(Behavior behavior)
        {
            this.behavior = behavior;
        }

        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        protected Behavior behavior;
        public string objectSound;//уберу
    }
}
