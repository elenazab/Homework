using System;


namespace Homework8
{
    public class PriorityQueue<T>
    {
        private class ListElement
        {
            public ListElement()
            { }

            public ListElement (T v, int p)
            {
                next = null;
                value = v;
                prio = p;
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

            public int GetPrio()
            {
                return prio;
            }

            private T value;
            private ListElement next;
            private int prio;
        }

        public PriorityQueue()
        {
            head = new ListElement();
        }

        public void Enqueue(T val, int prio)
        {
            ListElement l = head;
            while (l.GetNext() != null && l.GetNext().GetPrio() >= prio)
            {
                l = l.GetNext();
            }
            ListElement tmp = new ListElement(val, prio);
            tmp.SetNext(l.GetNext());
            l.SetNext(tmp);
        }

        public T Dequeue()
        {
            if (head.GetNext() == null)
                throw new QueueException();
            ListElement tmp = head.GetNext();
            head.SetNext(tmp.GetNext());
            return tmp.GetValue();
        }

    private ListElement head;
    }
}
