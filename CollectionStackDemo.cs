using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.cs
{
    public class CollectionStackDemo
    {
        public void Display()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(22);
            stack.Push(33);
            stack.Push(45);
            stack.Push(13);
            stack.Push(24);
            stack.Push(12);

            foreach(int item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop();

            Console.WriteLine("------");
            Console.WriteLine("the peek element is " + stack.Peek());
            Console.WriteLine("after poped");

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("the peek element is " + stack.Peek());
        }
    }
}
