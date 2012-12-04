using System.Collections.Generic;

namespace hw7t2
{
    public class Set<T>
    {
        public class SetElement
        {
            public SetElement()
            { }

            public SetElement (T v)
            {
                next = null;
                value = v;
            }

            public SetElement GetNext()
            {
                return next;
            }

            public void SetNext(SetElement nxt)
            {
                next = nxt;
            }

            public T GetValue()
            {
                return value;
            }

            private T value;
            private SetElement next;
        }

        public Set()
        {
            head = new SetElement();
        }

        public void Add(T val)
        {
            SetElement tmp = new SetElement(val);
            tmp.SetNext(head.GetNext());
            head.SetNext(tmp);
        }

        public bool IsExist(T val)
        {
            var tmp = this.head;
            while (tmp.GetNext() != null)
            {
                tmp = tmp.GetNext();
                if (EqualityComparer<T>.Default.Equals(tmp.GetValue(), val))
                    return true;
            }
            return false;
        }

        public void UnionOfSets(Set<T> secondSet)
        {
            var tmp = secondSet.head;
            while (tmp.GetNext() != null)
            {
                tmp = tmp.GetNext();
                if (!this.IsExist(tmp.GetValue()))
                    this.Add(tmp.GetValue());
            }
        }

        public Set<T> IntersectionsOfSets(Set<T> secondSet)
        {
            var newSet = new Set<T>();
            var tmp = secondSet.head;
            while (tmp.GetNext() != null)
            {
                tmp = tmp.GetNext();
                if (this.IsExist(tmp.GetValue()))
                    newSet.Add(tmp.GetValue());
            }
            return newSet;
        }

        public void Del(T val)
        {
            var tmp = this.head;
            if (this.IsExist(val))
            {
                
                while (!EqualityComparer<T>.Default.Equals(tmp.GetNext().GetValue(), val))
                {
                    tmp = tmp.GetNext();
                }
                var tmp2 = tmp.GetNext();
                tmp.SetNext(tmp2.GetNext());
            }
        }

        public SetElement head;
    }
}
