
namespace hw7t1
{
    public class Stack<T>: List<T>
    {
        public Stack()
        {
            head = new ListElement();
        }

        public void Push(T val)
        {
            ListElement tmp = new ListElement(val);
            tmp.SetNext(head.GetNext());
            head.SetNext(tmp);
        }

        public T Pop()
        {
            if (head.GetNext() == null)
                throw new StackException();
            var tmp = head.GetNext();
            head.SetNext(tmp.GetNext());
            return tmp.GetValue();
        }
    }
}
