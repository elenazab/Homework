using System;


namespace hw7t1
{
    class Program
    {
        static void Main()
        {
            Stack<int> mStack = new Stack<int>();
            mStack.Push(1);
            mStack.Push(2);
            mStack.Push(3);
            var i = mStack.Pop();
            i = mStack.Pop();
            i = mStack.Pop();
            i = mStack.Pop();
            Console.WriteLine(i);
            Console.Read();
        }
    }
}
