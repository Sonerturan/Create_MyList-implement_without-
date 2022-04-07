using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_MyList_implement_without_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(12);
            foreach (var item in sayilar.GetItems())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
