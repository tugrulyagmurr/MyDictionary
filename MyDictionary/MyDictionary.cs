using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<TKey,UValue>
    {
        KeyValuePair<TKey,UValue>[] items;

        public MyDictionary()
        {
            items=new  KeyValuePair<TKey, UValue>[0];
        }

        public void Add(TKey key,UValue value)
        {
            KeyValuePair<TKey, UValue>[] tempArray = items;
            items = new KeyValuePair<TKey, UValue>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = new KeyValuePair<TKey, UValue>(key, value);
        }

        

        public int Count
        {
            get { return items.Length; }
        }




    }
}
