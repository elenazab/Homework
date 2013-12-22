
namespace hw1t2
{
    class Linux: OS
    {
        public override bool SuccessfulVirusAttack()
        {
            return (rnd.Next(0, 100) > 65);
        }
    }
}
