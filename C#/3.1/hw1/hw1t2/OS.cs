using System;

namespace hw1t2
{
    abstract class OS
    {
        public OS()
        {
        }

        public void SetVirus()
        {
            if (SuccessfulVirusAttack())
                Virus = true;
        }

        abstract public bool SuccessfulVirusAttack();
        public bool Virus {get; set;}

        public Random rnd { get; set; }
    }
}
