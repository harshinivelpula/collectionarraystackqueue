using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.cs
{
    internal class CollectionListDemo
    {
        public void Display()
        {
            List<string> list = new List<string>();

            list.Add("ramesh");
            list.Add("suresh");
            list.Add("rita");

            foreach(string ele in list)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
