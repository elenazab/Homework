
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

        public void MakeMove(Map map)
        {
            var objDecision = behavior.Think(map);
            if (objDecision == Decision.WishUp && this.CoordinateY > 0)
            {
                this.NewCoordinate(map, this.CoordinateX, this.CoordinateY - 1);
            }
            if (objDecision == Decision.WishRight && this.CoordinateX < map.mapArray.Length - 1)
            {
                this.NewCoordinate(map, this.CoordinateX + 1, this.CoordinateY);
            }
            if (objDecision == Decision.WishDown && this.CoordinateY < map.mapArray.Length - 1)
            {
                this.NewCoordinate(map, this.CoordinateX, this.CoordinateY + 1);
            }
            if (objDecision == Decision.WishLeft && this.CoordinateX > 0)
            {
                this.NewCoordinate(map, this.CoordinateX - 1, this.CoordinateY);
            }
        }

        public MapObject()
        {
        }

        public void SetBehavior(Behavior behavior)
        {
            this.behavior = behavior;
        }

        public void NewCoordinate(Map map, int x, int y)
        {
            map.mapArray[this.CoordinateX][this.CoordinateY - 1].listOfObjects.Add(this);
            map.mapArray[this.CoordinateX][this.CoordinateY].listOfObjects.Remove(this);
            this.CoordinateX = x;
            this.CoordinateY = y;
        }

        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        protected Behavior behavior;
        public string objectSound;//уберу
    }
}
