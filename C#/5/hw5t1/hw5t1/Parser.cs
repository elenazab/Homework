using System;

namespace hw5t1
{
    public class Parser
    {
        public void BuildTree(Tree mTree, string s, int i)
        {
            i++;
            if (s[i] == ')')
                i++;
            if (s[i] == '(')
            {
                i++;
                if (s[i] == '+')
                    mTree = new Plus();
                if (s[i] == '-')
                    mTree = new Minus();
                if (s[i] == '*')
                    mTree = new Multiplication();
                if (s[i] == '/')
                    mTree = new Division();
                this.BuildTree(mTree.Left, s, i);
                this.BuildTree(mTree.Right, s, i);
            }
            if (Char.IsDigit(s[i]))
                mTree = new Operand(Convert.ToInt32(s[i])-'0');
        }

        public void PrintTree(Tree mTree)
        {
            if (mTree.Left != null)
                this.PrintTree(mTree.Left);
            mTree.Print();
            if (mTree.Right != null)
                this.PrintTree(mTree.Right);
        }
    }
}
