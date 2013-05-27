
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
            return behavior.Think(map);
        }

        public MapObject()
        {
        }

        public void SetBehavior(Behavior behavior)
        {
            this.behavior = behavior;
        }

        public void NewCoordinate(int x, int y)
        {
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        protected Behavior behavior;
        public string objectSound;//уберу
    }
}
