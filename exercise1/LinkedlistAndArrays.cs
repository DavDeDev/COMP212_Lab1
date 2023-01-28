using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavidPietrocola_Lab1.exercise1
{
    internal class LinkedlistAndArrays
    {
        public static void Main(string[] args)
        {
            //TODO: Use example(s) to illustrate the differences between array and linked list
            
            // arrays are fixed in size, which means that you can't add values after its creation
            int[] array = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array: ");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            // LinkedList can be created with a fixed size or without a size
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            numbers.AddLast(5);
            numbers.RemoveLast();
            // We can add and remove values after its initialization

            Console.WriteLine("LinkedList: ");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Prevent the console from closing
            Console.ReadKey();
        }


    }


}
