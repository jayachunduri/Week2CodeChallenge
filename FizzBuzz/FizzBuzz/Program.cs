using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        //Calling Fizz Buzz for numbers 0 to 20
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
                Fizzbuzz(i);
        }

        static void Fizzbuzz(int num)
        {
            if((num % 5 == 0) && (num % 3 == 0))
                Console.WriteLine("Fizz Buzz");
            else if(num % 5 == 0)
                Console.WriteLine("Fizz");
            else if(num % 3 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(num);
        }
    }
}
