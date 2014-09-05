using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class LetterCounter
    {
        static void Main(string[] args)
        {
            //calling CountLetters
            CountLetters('i', "I love biscuits and gravy. It's the best breakfast ever");
            CountLetters('n', "Never gonna give you up. Never gonna let you down");
            CountLetters('s', "Sally sells seashells down by the seahore. She's from Sussex");
        }

        public static void CountLetters(char letter, string inString)
        {
            //variables to keep track of counts
            int lower = 0, upper = 0;

            //Changed the letter to lower and upper case
            string lowercase = letter.ToString().ToLower();
            string uppercase = letter.ToString().ToUpper();

            //looping through each letter of inString and counting number of upper and lower case instances
            for (int i = 0; i < inString.Length; i++)
            {
                if (inString[i].ToString() == lowercase)
                    lower++;

                else if (inString[i].ToString() == uppercase)
                    upper++;
            }

            //Printing output
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lower case: " + lower);
            Console.WriteLine("Number of UPPER case: " + upper);
            Console.WriteLine("Total number of " +letter +" s found: " +(upper+lower) +"\n");
        }
    }
}
