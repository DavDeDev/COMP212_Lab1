using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidPietrocola_Lab1.exercise1
{
    internal class Class1
    {
        //Use example(s) to illustrate the features of stack and queue
        public static void Main(string[] args)
        {
            // Stack is a LIFO (Last In First Out) data structure
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            // This will remove the last value added to the stack
            stack.Pop();

            Console.WriteLine("Stack: ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }


            // Queue is a FIFO (First In First Out) data structure
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            // This will remove the first value added to the queue
            queue.Dequeue();

            Console.WriteLine("Queue: ");
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            // Prevent the console from closing
            Console.ReadKey();
        }
    }
}
