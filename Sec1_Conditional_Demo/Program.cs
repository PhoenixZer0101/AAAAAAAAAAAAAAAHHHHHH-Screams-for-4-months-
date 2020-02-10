using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Erin Cascioli
// 2/3/2020
// Demo: Conditionals (If statements)

namespace Sec1_Conditional_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will display for all users each time the program starts
            Console.WriteLine("Do you want to play? Enter 'true' or 'false'");

            // Gather their input and sanitize it - 
            //   converts it to all lowercase and removes any leading or trailing spaces.
            string userInput = Console.ReadLine().ToLower().Trim();
            bool isUserPlaying = bool.Parse(userInput);

            // Does user want to play the game?
            // Compare the boolean variable against the constant 'true'
            //if(isUserPlaying == true)
            // Or by leaving off the '== true', a boolean variable by itself is interpreted as 'true'
            if (isUserPlaying)
            {
                // 1. Ask user for their favorite season and grab their choice
                Console.Write("What is your favorite season? ");
                userInput = Console.ReadLine();

                // 2. Sanitize input
                // You can do this in 2 steps:  
                string userInputClean = userInput.ToLower();    //Or ToUpper()
                userInputClean = userInputClean.Trim();
                // Or all in one step:
                //string userInputClean = userInput.ToLower().Trim();

                // 3. Let the user know if their favorite season was "right" or not
                if (userInputClean == "summer")
                {
                    Console.WriteLine("YESSSSS.");
                }
                else if(userInputClean == "winter")
                {
                    Console.WriteLine("Ok then go skiing then.");
                }
                else
                {
                    Console.WriteLine("Wrong.");
                }
            }

            // Output will occur whether the user plays or not
            Console.WriteLine("Goodbye.");
        }
    }
}
