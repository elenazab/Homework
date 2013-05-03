using System;

namespace Map
{
    class FieldTree: MapObject
    {
        public FieldTree(Behavior behavior)
            : base(behavior)
        {
            image = 'W';
            objectSound = "hhhhh";
        }
    }
}
