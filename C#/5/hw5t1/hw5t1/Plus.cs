using System;

namespace hw5t1
{
    public class Plus: Tree
    {
        public override double Calculate()
        {
            return (this.Left.Calculate() + this.Right.Calculate());
        }

        public override void Print()
        {
            Console.Write('+');
        }
    }
}
