using System;

namespace Loops_Livingston_Stephen
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Why do you want to make games?"); // Asks the user a question
            string response = Console.ReadLine(); // Reads the users response
           
            Console.WriteLine($"The sentence, \"{response}\"has {CountNumbersOfSpaces(response)} spaces in it."); // Prints the response

            Console.WriteLine("Please enter a whole number"); // Asks the user for input
            
            string response2 = Console.ReadLine(); // Reads the users response
            
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!"); // Prints the response
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns></returns>
        static int CountNumbersOfSpaces(string sentence) 
        {
            int numberOfSpaces = 0;
            foreach (char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Number of spaces in the sentence</returns>
       static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum; 
        }
    }
}
