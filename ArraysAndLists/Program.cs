using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an int Array and populate numbers 1-10

            var arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Create two Lists of type int.

            var evens = new List <int> ();
            var odds = new List <int> ();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var x in arr)
	        {
                if (x % 2 == 0)
                {
                    evens.Add (x);
                }
                else
                {
                    odds.Add (x);
                }

            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */


            Console.WriteLine();

            foreach (var itemX in evens)
	        {
                Console.WriteLine($"{itemX} is an even number here!");
	        }

            Console.WriteLine();

            foreach (var itemY in evens)
	        {
                Console.WriteLine($"{itemY} is an odd number here!");
	        }
        }
    }
}
