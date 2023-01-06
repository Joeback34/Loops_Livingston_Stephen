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
        /// Counts the number os spaces in the sentence by using foreach, if and return statements
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns></returns>
        static int CountNumbersOfSpaces(string sentence) // Method that counts the number of spaces
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
        /// Prints the sum of the users input.d
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
