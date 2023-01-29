using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DavidPietrocola_Lab1.exercise1
{
    //Use example to demonstrate what a type constraint is
    internal class TypeConstraint
    {
        public static void testClassConstraint<E>(E e) where E : class // E must be a reference type
        {
            Console.WriteLine("The argument passed is a reference type: " + e.GetType().ToString());
        }

        public static void testStructConstraint<T>(T t) where T : struct
        {
            Console.WriteLine("The argument passed is a value type: " + t.GetType().ToString());
        }

        static void Main(string[] args)
        {
            int valueType = 10; // integer is a value type
            string referenceType = "ciao"; //string is a reference type

            testClassConstraint(referenceType);
            //testClassConstraint(valueType); // This is not executable as long as int is NOT a reference type

            testStructConstraint(valueType);
            //testStructConstraint(referenceType); // This is not executable as long as string is NOT a value type


            Console.ReadKey();
        }
    }
}