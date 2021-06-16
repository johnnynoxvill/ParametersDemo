using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testVal1 = 1;
            Console.WriteLine("Original Value: {0}", testVal1);
            Test(testVal1);
            Console.WriteLine("Returned Value: {0}", testVal1);

            //out can be initialized inside the method
            int testVal2;
           // Console.WriteLine("Original Value: {0}", testVal2);
            TestOut(out testVal2);
            Console.WriteLine("Returned Value: {0}", testVal2);

            //ref cannot be initialized inside the method
            int testVal3 = 3;
            Console.WriteLine("Original Value: {0}", testVal3);
            TestRef(ref testVal3);
            Console.WriteLine("Returned Value: {0}", testVal3);


            Console.WriteLine("\nCalling TestOptional with a parameter");
            TestOptional(510);

            Console.WriteLine("\nCalling TestOptional with no parameter");
            TestOptional();

            Console.WriteLine("\nTestMultiple all three set");
            TestMultiple(1, 2, 3);

            Console.WriteLine("\nTestMultiple set first two");
            TestMultiple(1, 2);

            Console.WriteLine("\nTestMultiple set first two");
            TestMultiple(1, cValue: 3);
        }

        public static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
        {
            Console.WriteLine("In TestMultiple Values are {0}, {1}, {2}", 
                aValue, bValue, cValue);
        }


        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In Test Value is {0}", aValue);
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut Value is {0}", aValue);

        }

        public static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine("In TestOut Value is {0}", aValue);

        }

        public static void TestOptional(int aValue = 444)
        {
            Console.WriteLine("In TestOptional Value is {0}", aValue);
        }
    }
}
