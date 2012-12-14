using System;

namespace hw5t1
{
    public class Operand: TreeNode
    {
        public override double Calculate()
        {
            return value;
        }

        public Operand(int v)
        {
            this.value = v;
        }

        public override void Print()
        {
            Console.Write(value);
        }

        private int value;
    }
}
