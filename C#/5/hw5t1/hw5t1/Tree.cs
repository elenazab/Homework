namespace hw5t1
{
    abstract public class Tree
    {
        public Tree()
        {
            Left = null;
            Right = null;
        }
        abstract public double Calculate();
        abstract public void Print();
        public Tree Left;
        public Tree Right;
    }
}