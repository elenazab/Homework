using System;

namespace hw1t2
{
    class Linux: OS
    {
        public override bool SuccessfulVirusAttack()
        {
            var rnd = new Random();
            if (rnd.Next(0, 100) > 65)
                return true;
            return false;
        }
    }
}
