using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CountWords
{
    class Program
    {
        //Implement an extension method for class StringBuilder to count the number of words contained in a
        //StringBuilder object. For example, if a StringBuilder object sb = ”This is to test whether the extension
        //method count can return a right answer or not”, the number of words contained in sb is 16.
        static void Main(string[] args)
        {
            string str;
            Console.Write("\nEnter a string: ");
            str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            Console.WriteLine("Number of words in the string: " + CountWords(sb));
            Console.ReadKey();
        }

        static int CountWords(StringBuilder sb)
        {
            IEnumerable<string> words = sb.ToString().Split(' ');
            int count = 0;
            foreach (var c in words)
            {
                count++;
            }
            return count;
        }
    }
}
