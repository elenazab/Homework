using System;

namespace Map
{
    class FieldTree: MapObject
    {
        public FieldTree(Behavior behavior)
        {
            image = 'W';
            this.behavior = behavior;
        }
    }
}
