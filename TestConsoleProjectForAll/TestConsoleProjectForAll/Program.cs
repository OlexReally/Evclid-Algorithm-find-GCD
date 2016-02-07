/*
Creator - Kutaev O.
C# algorithm Evclid
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace TestConsoleProjectForAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0, numberTwo = 0;

            Console.WriteLine("Enter first number: ");
            numberOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            numberTwo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Result is: {0}", GetGCD(numberOne, numberTwo));

        }
        
        static int GetGCD(int one, int two)
        {
            int tmp = 0;
            while(two != 0)
            {
                tmp = one % two;
                one = two;
                two = tmp;
            }
            return one;
        }
        
    }
}