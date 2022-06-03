using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers 1000 through -1000: ");
            PrintNums(1000, -1000);

            Console.ReadKey();

            Console.WriteLine("\n\nNumbers 3 - 999 by 3's: ");
            PrintNums(3, 999, 3);
            
            Console.ReadKey();

            Console.WriteLine("\n\nTesting IsEven method: ");
            var testNum = 67843;
            bool isEven=IsEven(testNum);
            Console.WriteLine($"The number {testNum} is " + (isEven ? "even" : "odd"));
            testNum = 65476;
            isEven=IsEven(testNum);
            Console.WriteLine($"The number {testNum} is " + (isEven ? "even" : "odd"));
            Console.ReadKey();

            Console.WriteLine("\n\nTesting IsPos method: ");
            testNum = 5;
            bool isPos = IsPos(testNum);
            Console.WriteLine($"The number {testNum} is " + (isPos ? "positive" : "negative"));
            testNum = -12;
            isPos = IsPos(testNum);
            Console.WriteLine($"The number {testNum} is " + (isPos ? "positive" : "negative"));
            Console.ReadKey();

            int voterAge = -1;
            Console.WriteLine("\n\nHow old is the prospective voter?");
            if (!int.TryParse(Console.ReadLine(), out voterAge) || voterAge < 0) Console.WriteLine("Error: invalid age.");
            else Console.WriteLine(CheckVoterAge(voterAge) ? "Old enough to vote." : "Too young to vote.");
            Console.ReadKey();

            Console.WriteLine("\n\nEnter an integer: ");
            if (!int.TryParse(Console.ReadLine(), out testNum)) Console.WriteLine("Not an integer.");
            else Console.WriteLine(IsInRange(testNum, -10, 10) ? "Falls between -10 and 10" : "Outside of -10 to 10");
            Console.ReadKey();
            Console.WriteLine($"\n\nHere is {testNum} multiplied by 1-12: ");
            PrintMultiples(testNum, 12);
            Console.ReadKey();

            Console.WriteLine("\n\nGoodbye!");
            Console.ReadKey();
        }


        static void PrintNums(int a, int b, int countBy = 1)
        {
            if (a == b) Console.WriteLine("Invalid input.");
            bool forward = (a < b) ? true : false;

            if (forward) for (int i = a; i <= b; i += countBy) Console.Write(i + " ");
            else for (int i = a; i >= b; i -= countBy) Console.Write(i + " ");
        }

        static bool IsEven(int a) => a % 2 == 0;
        static bool IsPos(int a) => a > 0;
        static bool CheckVoterAge(int v) => v >= 18;
        static bool IsInRange(int a, int low, int high) => (a >= low && a <= high);
        static void PrintMultiples(int n, int maxMultiplier)
        {
            for (int i = 1; i <= maxMultiplier; i++) Console.WriteLine($"{n} * {i} = " + n * i);
        }


    }
}
