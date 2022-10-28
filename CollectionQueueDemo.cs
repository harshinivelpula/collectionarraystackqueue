using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.cs
{
    public class CollectionQueueDemo
    {
        public void Display()
        {
            Queue<int> queu = new Queue<int>();

            queu.Enqueue(1);
            queu.Enqueue(2);
            queu.Enqueue(3);
            queu.Enqueue(4);

            foreach(var item in queu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            Console.WriteLine("the peek element is " + queu.Peek());
            Console.WriteLine("-------");
            queu.Dequeue();
            Console.WriteLine("after Dequeued");

            foreach (int item in queu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            Console.WriteLine("the peek element is " + queu.Peek());
            Console.WriteLine("-------");
            queu.Dequeue();
            Console.WriteLine("after Dequeued");

            foreach (int item in queu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            Console.WriteLine("the peek element is " + queu.Peek());
            Console.WriteLine("-------");
            queu.Dequeue();
            Console.WriteLine("after Dequeued");

            foreach (int item in queu)
            {
                Console.WriteLine(item);
            }
        }

    }
}
