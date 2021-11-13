using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class _MyDictionary<T,F>
    {
        T[] tItem;
        F[] fItem;
        public _MyDictionary()
        {
            tItem = new T[0];
            fItem = new F[0];
        }
        public void Add(T TKey, F TValue)
        {
            T[] tempArray = tItem;
            F[] _tempArray = fItem;
            tItem = new T[tItem.Length + 1];
            fItem = new F[fItem.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tItem[i] = tempArray[i];
                fItem[i] = _tempArray[i];
            }
            tItem[tItem.Length - 1] = TKey;
            fItem[fItem.Length - 1] = TValue;
        }
        public int Count()
        {
            return tItem.Length;
        }
    }
}
