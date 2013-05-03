using System;

namespace Map
{
    class StonedCat: MapObject
    {
        public StonedCat(Behavior behavior)
            : base(behavior)
        {
            image = 'X';
            objectSound = "MEOWMEOW";
        }
    }
}
