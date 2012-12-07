using System;

namespace hw1t2
{
    class Windows: OS
    {
        public override bool SuccessfulVirusAttack()
        {
            var rnd = new Random();
            if (rnd.Next(0, 100) > 55)
                return true;
            return false;
        }
    }
}
