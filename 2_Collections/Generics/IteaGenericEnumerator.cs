using ITEA_Collections.Generics.Testing;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ITEA_Collections.Generics
{
    public class IteaGenericEnumerator<T> : IEnumerator<T>
    {
        #region IEnumerator
        private List<T> collection;
        private int curIndex = -1;
        public T Current { get; }
        
        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            //Dispose(true);
            //GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            curIndex++;
            return (curIndex < collection.Count && collection[curIndex]!=null);
        }

        public void Reset()
        {
            curIndex = -1; 

        }
        #endregion
    }
}
