using System;

namespace hw5t1
{
    public class Parser
    {
        public TreeNode BuildTree(string s, ref int i)
        {
            i++;
            if (s[i] == ')')
                i++;
            if (s[i] == '(')
            {
                i++;
                AbstractOperation newTree = null;
                if (s[i] == '+')
                    newTree = new Plus();
                if (s[i] == '-')
                    newTree = new Minus();
                if (s[i] == '*')
                    newTree = new Multiplication();
                if (s[i] == '/')
                    newTree = new Division();
                newTree.Left = this.BuildTree(s, ref i);
                newTree.Right = this.BuildTree(s, ref i);
                return newTree;
            }
            else if (Char.IsDigit(s[i]))
            {
                Operand newTree = new Operand(Convert.ToInt32(s[i]) - '0');
                return newTree;
            }
            return null;
        }
    }
}
