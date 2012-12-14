using System;

namespace hw5t1
{
    public class Multiplication: AbstractOperation
    {
        public override double Calculate()
        {
            return this.Left.Calculate() * this.Right.Calculate();
        }

        public override void Print()
        {
            if (this.Left != null)
                this.Left.Print();
            Console.Write('*');
            if (this.Right != null)
                this.Right.Print();
        }
    }
}
