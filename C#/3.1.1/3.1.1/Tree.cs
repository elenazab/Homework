using System.Collections;
using System.Collections.Generic;


namespace hw311
{
    /// <summary>
    /// дерево
    /// </summary>
    public class Tree : IEnumerable
    {

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// итератор
        /// </summary>
        public class Iterator : IEnumerator
        {
            /// <summary>
            /// консруктор итератора
            /// </summary>
            /// <param name="collection"></param>
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

            /// <summary>
            /// следующий элемент
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                return listEnumerator.MoveNext();

            }

            /// <summary>
            /// текущий элемент
            /// </summary>
            public int Current
            {
                get
                {
                    return listEnumerator.Current;
                }
            }

            /// <summary>
            /// перезагрузка итератора
            /// </summary>
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

        /// <summary>
        /// элемент дерева
        /// </summary>
        public class TreeElement
        {

            /// <summary>
            /// конструктор элемента дерева
            /// </summary>
            public TreeElement()
            {
            }

            /// <summary>
            /// конструктор элемента дерева с параметрами
            /// </summary>
            /// <param name="v"></param>
            public TreeElement(int v)
            {
                right = null;
                left = null;
                value = v;
            }

            /// <summary>
            /// указаель на левое поддерево
            /// </summary>
            /// <returns></returns>
            public TreeElement GetLeft()
            {
                return left;
            }

            /// <summary>
            /// указаель на правое поддерево
            /// </summary>
            /// <returns></returns>
            public TreeElement GetRight()
            {
                return right;
            }

            /// <summary>
            /// присвоение указателя на левое поддерево
            /// </summary>
            /// <param name="next"></param>
            public void SetLeft(TreeElement next)
            {
                left = next;
            }

            /// <summary>
            /// присвоение указателя на правое поддерево
            /// </summary>
            /// <param name="next"></param>
            public void SetRight(TreeElement next)
            {
                right = next;
            }

            /// <summary>
            /// числовое значение элемента
            /// </summary>
            /// <returns></returns>
            public int GetValue()
            {
                return value;
            }

            /// <summary>
            /// присваивание числового значения элементу
            /// </summary>
            /// <param name="value"></param>
            public void SetValue(int value)
            {
                this.value = value;
            }

            private int value;
            private TreeElement left;
            private TreeElement right;
        }

        /// <summary>
        /// конструктор дерева
        /// </summary>
        public Tree()
        {
        }

        /// <summary>
        /// добавление элемента в дерево
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// проверка элемента на принадлежность дереву
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// удаление элемента дерева
        /// </summary>
        /// <param name="value"></param>
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
