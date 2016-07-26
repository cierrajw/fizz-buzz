using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task: Write a program that will print out numbers 1-100
            // Except, if the number is a multiple of 3 print out 'Fizz'
            // if the number is a multiple of 5 print out 'Buzz'
            // if the number is a multiple of both 3 AND 5 print out 'FizzBuzz'
            /*
             * 1
             * 2
             * Fizz
             * 4
             * Buzz
             * Fizz
             * 7
             * 8
             * Fizz
             * Buzz
             * 11
             * Fizz
             * 13
             * 14
             * FizzBuzz
             */

            for (int num = 1; num <= 100; num++)
            {
                Console.ReadKey();
                // if (num % 15 == 0)
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // else if (num % 5 == 0 && num % 3 == 0)
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadKey();


        }
    }
}
