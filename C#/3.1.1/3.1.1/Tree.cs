using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw311
{
    public class Tree//<T>: IEnumerable<T>
    {
/*
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new Iterator<T>(this);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Iterator<T>(this);
        }
*/

        public class TreeElement
        {
            public TreeElement()
            {
            }

            public TreeElement (int v)
            {
                right = null;
                left = null;
                value = v;
            }

            public TreeElement GetLeft()
            {
                return left;
            }

            public TreeElement GetRight()
            {
                return right;
            }

            public void SetLeft(TreeElement next)
            {
                left = next;
            }

            public void SetRight(TreeElement next)
            {
                right = next;
            }

            public int GetValue()
            {
                return value;
            }

            public void SetValue(int value)
            {
                this.value = value;
            }

            private int value;
            private TreeElement left;
            private TreeElement right;
        }

        public Tree()
        {
        }


        public void Add(int value)
        {
            if (head == null)
            {
                head = new TreeElement(value);
            }
            else
            {
                TreeElement tmpHead = head;
                while (true)
                {
                    if (tmpHead.GetValue() == value)
                        return;
                    if (tmpHead.GetValue() > value)
                    {
                        if (tmpHead.GetLeft() == null)
                        {
                            tmpHead.SetLeft(new TreeElement(value));
                            return;
                        }
                        else
                        {
                            tmpHead = tmpHead.GetLeft();
                        }
                    }
                    if (tmpHead.GetValue() < value)
                    {
                        if (tmpHead.GetRight() == null)
                        {
                            tmpHead.SetRight(new TreeElement(value));
                            return;
                        }
                        else
                        {
                            tmpHead = tmpHead.GetRight();
                        }
                    }
                }
            }
        }

        public bool IsExists(int value)
        {
            TreeElement tmpHead = this.head;
            while (tmpHead != null)
            {
                if (tmpHead.GetValue() == value)
                    return true;
                if (tmpHead.GetValue() < value)
                    tmpHead = tmpHead.GetRight();
                if (tmpHead.GetValue() > value)
                    tmpHead = tmpHead.GetLeft();
            }
            return false;
        }

        public void Delete(int value)
        {
            if (this.IsExists(value) == false)
                return;
            if (this.head.GetValue() == value && this.head.GetRight() == null
                && this.head.GetLeft() == null)
            {
                this.head = null;
                return;
            }
            TreeElement counter = this.head;
            TreeElement previousCounter = this.head;
            while (counter.GetValue() != value)
            {
                if (counter.GetValue() == value)
                {
                    break;
                }
                if (counter.GetValue() < value)
                {
                    counter = counter.GetRight();
                    if (previousCounter.GetRight().GetValue() != value)
                    {
                        previousCounter = previousCounter.GetRight();
                    }
                    else
                    {
                        counter = counter.GetLeft();
                        if (previousCounter.GetLeft().GetValue() != value)
                        {
                            previousCounter = previousCounter.GetLeft();
                        }
                    }
                }
                if (counter.GetLeft() == null && counter.GetRight() == null)
                {
                    if (previousCounter.GetLeft() == counter)
                    {
                        previousCounter.SetLeft(null);
                    }
                    else
                    {
                        previousCounter.SetRight(null);
                    }
                    return;
                }
                if (counter.GetLeft() == null && counter.GetRight() != null)
                {
                    if (previousCounter.GetLeft() == counter)
                    {
                        previousCounter.SetLeft(counter.GetRight());
                    }
                    else
                    {
                        previousCounter.SetRight(counter.GetRight());
                    }
                    return;
                }
                if (counter.GetLeft() != null && counter.GetRight() == null)
                {
                    if (previousCounter.GetLeft() == counter)
                    {
                        previousCounter.SetLeft(counter.GetLeft());
                    }
                    else
                    {
                        previousCounter.SetRight(counter.GetLeft());
                    }
                    return;
                }
                if (counter.GetLeft() != null && counter.GetRight() != null)
                {
                    TreeElement searchCounter = counter.GetRight();
                    while (searchCounter.GetLeft() != null)
                    {
                        searchCounter = searchCounter.GetLeft();
                    }
                    int tmp = searchCounter.GetValue();
                    Delete(searchCounter.GetValue());
                    counter.SetValue(tmp);
                    return;
                }
            }
        }

        public TreeElement head;
    }
}
