using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw311
{/*
    public class Iterator<T>: IEnumerator<T>
    {
        public Iterator(Tree<T> collection)
        {
            mCollection = collection;
            curTreeElement = mCollection.head;
        }

        public bool MoveNext()
        {
            if (curTreeElement.GetLeft() == null && curTreeElement.GetRight() == null)
                return false;
            if (curTreeElement.GetLeft() != null)
            {
                curTreeElement = curTreeElement.GetLeft();
                MoveNext();
                return true;
            }
            if (curTreeElement.GetRight() != null)
            {
                curTreeElement = curTreeElement.GetRight();
                MoveNext();
                return true;
            }
            return true;
        }

        public int Current
        {
            get
            {
                return curTreeElement.GetValue();
            }
        }

        public void Reset()
        {
            curTreeElement = mCollection.head;
        }

        void IDisposable.Dispose() { }

        object System.Collections.IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        private Tree<T> mCollection;
        private Tree<T>.TreeElement curTreeElement;
    }
*/}
    