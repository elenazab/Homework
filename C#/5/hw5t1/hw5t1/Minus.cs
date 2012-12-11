using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5t1
{
    public class Minus: Tree
    {
        public override double Calculate()
        {
            return (this.Left.Calculate() - this.Right.Calculate());
        }

        public override void Print()
        {
            Console.Write('-');
        }
    }
}
