using System;

namespace hw5t1
{
    public class Parser
    {
        public TreeNode BuildTree(string s, int i)
        {
            i++;
            if (s[i] == ')')
                i++;
            if (s[i] == '(')
            {
                i++;
                AbstractOperation newTree = new AbstractOperation();
                if (s[i] == '+')
                    newTree = new Plus();
                if (s[i] == '-')
                    newTree = new Minus();
                if (s[i] == '*')
                    newTree = new Multiplication();
                if (s[i] == '/')
                    newTree = new Division();
                newTree.Left = this.BuildTree(s, i);
                newTree.Right = this.BuildTree(s, i);
                return newTree;
            }
            else if (Char.IsDigit(s[i]))
            {//  а в чем смысл того, что нельзя инициализировать переменную после if()? пришлось ставить скобки, чтобы скомпилилось.
                Operand newTree = new Operand(Convert.ToInt32(s[i]) - '0');
                return newTree;
            }
            return null;// а без этого можно? у меня никак не работало
        }
    }
}
