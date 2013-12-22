using System;

namespace hw1t2
{
    class Windows: OS
    {
        public override bool SuccessfulVirusAttack()
        {
            return (rnd.Next(0, 100) > 55);
        }
    }
}
