using System;

namespace Map
{
    class Elf: MapObject
    {
        public Elf(Behavior behavior)
            : base(behavior)
        {
            image = 'X';
        }
    }
}
