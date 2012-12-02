using System.Collections.Generic;
using System;

namespace hw7t1
{
    public class Iterator<T>: IEnumerator<T>
    {
        private List<T> mCollection;
        private List<T>.ListElement curListElement;

        public Iterator(List<T> collection)
        {
            mCollection = collection;
            curListElement = mCollection.head.GetNext();
        }

        public bool MoveNext()
        {
            if (curListElement.GetNext()==null)
                return false;
            else
                curListElement.SetNext(curListElement.GetNext());
            return true;
        }

public T Current
{
    get 
    {
        return curListElement.GetValue();
    }
}
public void Reset()
{
    curListElement = mCollection.head;
}

void IDisposable.Dispose() { }

object System.Collections.IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
    }
}
