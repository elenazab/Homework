
namespace hw7t1
{
    public class List<T>
    {
        public Iterator<T> GetEnumerator()
        {
            return new Iterator<T>(this);
        }

        public class ListElement
        {
            public ListElement()
            { }

            public ListElement (T v)
            {
                next = null;
                value = v;
            }

            public ListElement GetNext()
            {
                return next;
            }

            public void SetNext(ListElement nxt)
            {
                next = nxt;
            }

            public T GetValue()
            {
                return value;
            }

            private T value;
            private ListElement next;
        }

        public List()
        {
            head = new ListElement();
        }

        public void Add(T val)
        {
            ListElement l = head;
            while (l.GetNext() != null)
            {
                l = l.GetNext();
            }
            ListElement tmp = new ListElement(val);
            tmp.SetNext(l.GetNext());
            l.SetNext(tmp);
        }

        public T Del()
        {
            ListElement tmp = head.GetNext();
            head.SetNext(tmp.GetNext());
            return tmp.GetValue();
        }

    public ListElement head;
    }
}
