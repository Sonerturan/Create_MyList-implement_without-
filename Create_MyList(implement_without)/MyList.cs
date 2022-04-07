using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_MyList_implement_without_
{
    class MyList<T>//generic class
    {
        T[] items;
        public MyList()//ctor
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//geçici dizide elemanları tutuyoruz(temporary array)
            items = new T[items.Length + 1];//dizinin eleman sayısını bir arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1]=item;
        }
        public T[] GetItems()
        {
            return items;
        }
    }
}
