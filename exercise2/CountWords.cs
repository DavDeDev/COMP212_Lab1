using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CountWords
{
class Program
{
static void Main(string[] args)
{
string str;
Console.Write("\nEnter a string: ");
str = Console.ReadLine();
StringBuilder sb = new StringBuilder(str);
IEnumerable<string> words = sb.ToString().Split(' ');
int count = 0;
foreach (var c in words)
{
count++;
}
Console.WriteLine("\nThe number of words contained in sb is "+count);
Console.ReadKey();
}
}
}
