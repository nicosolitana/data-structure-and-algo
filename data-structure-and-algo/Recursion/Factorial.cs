using System;
using System.Collections.Generic;
using System.Text;

namespace data_structure_and_algo.Recursion
{
    class Factorial
    {
        private static int GetFactorial(int n)
        {
            if (n == 0) return 1;
            return n * GetFactorial(n - 1);
        }

        private static int GetFactorialTail(int n, int result)
        {
            if (n == 0) return result;
            return GetFactorialTail(n - 1, n * result);
        }
        private static int GetFactorialTail(int n)
        {
            return GetFactorialTail(n, 1);
        }

        public static void TestFactorial()
        {
            int n = 10;
            int value = GetFactorial(n);
            int tailValue = GetFactorialTail(n);
            Console.WriteLine("\nRecurive Factorial");
            Console.WriteLine("Factorial of {0} is {1}", n, value);
            Console.WriteLine("Tail Factorial of {0} is {1}", n, tailValue);
        }
    }
}
