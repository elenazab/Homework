using System.Collections.Generic;

namespace hw7t1
{
    public class Iterator: IEnumerator<ListElement>
    {
        private List<T> mCollection;
        private ListElement curListElement;

        public Iterator(List<T> collection)
        {
            mCollection = collection;
            curListElement = mCollection.head.GetNext();
        }

        public bool MoveNext()
        {
            if (!curListElement.GetNext())
                return false;
            else
                curListElement.SetNext(curListElement.GetNext());
            return true;
        }

public T Current
{
    get 
    {
        return curListElement;
    }
}
public void Reset()
{
    curListElement = mCollection.head;
}

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    }
}
