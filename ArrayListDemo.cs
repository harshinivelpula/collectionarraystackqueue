using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class ArrayListDemo
    {
        public void Display()
        {
            int[] arr = new int[2];

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2.2);
            arrayList.Add(true);
            arrayList.Add("test" );

            foreach(var ele in arrayList)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("--------");
            Console.WriteLine(arrayList.Count);

            Console.WriteLine("--------");
            Console.WriteLine("after removing");
            arrayList.RemoveAt(1);

            foreach (var ele in arrayList)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("--------");
            Console.WriteLine("after contanis");
            bool val = arrayList.Contains(1);
            Console.WriteLine(val);

        }

       
    }
}
