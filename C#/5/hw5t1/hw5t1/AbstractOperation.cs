
namespace hw5t1
{
    public class AbstractOperation: TreeNode
    {
        public AbstractOperation()
        {
            Left = null;
            Right = null;
        }
        public override double Calculate()
        {
            return 0;
        }
        public override void Print()
        {
        }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }
}
