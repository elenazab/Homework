using System.Collections;
using System.Collections.Generic;


namespace hw311
{
    public class Tree: IEnumerable
    {

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new Iterator(this);
        }

        public class Iterator : IEnumerator
        {
            public Iterator(Tree collection)
            {
                this.list = new List<int>();
                InitList(collection.head);
                listEnumerator = list.GetEnumerator();
            }

            private void InitList(TreeElement tree)
            {
                if (tree.GetLeft() != null)
                    InitList(tree.GetLeft());
                list.Add(tree.GetValue());
                if (tree.GetRight() != null)
                    InitList(tree.GetRight());
            }

            public bool MoveNext()
            {
                return listEnumerator.MoveNext();

            }

            public int Current
            {
                get
                {
                    return listEnumerator.Current;
                }
            }

            public void Reset()
            {
                listEnumerator.Reset();
            }

            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return listEnumerator.Current;
                }
            }

            private List<int> list;
            IEnumerator<int> listEnumerator;
        }

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
                }
                    else
                    {
                        counter = counter.GetLeft();
                        if (previousCounter.GetRight().GetValue() != value)
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
                    counter = null;
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

        private TreeElement head;
    }
}
