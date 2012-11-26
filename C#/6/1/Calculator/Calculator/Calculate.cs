using System;


namespace Calculator
{
    public class MyCalculate
    {
        public static int Calc(int oper1, int oper2, string operat)
        {
            if (operat == "+")
                return oper1 + oper2;
            if (operat == "-")
                return oper1 - oper2;
            if (operat == "*")
                return oper1 * oper2;
            if (operat == "/")
                return oper1 / oper2;
            return 0;
        }
    }
}
