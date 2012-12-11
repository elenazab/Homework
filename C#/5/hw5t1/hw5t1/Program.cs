
namespace hw5t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plus t = new Plus();
            Tree pointer = t;
            pointer = pointer.Left;
            Parser tP = new Parser();
            tP.BuildTree(pointer, "(+11)", -1);
            tP.PrintTree(pointer);
        }
    }
}
