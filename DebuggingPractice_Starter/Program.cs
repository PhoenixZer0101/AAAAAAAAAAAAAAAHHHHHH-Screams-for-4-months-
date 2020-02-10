using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Debugging Starter
// Use this code to practice debugging.  

namespace DebuggingPractice_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print greeting and rules
            Console.WriteLine("Answer questions to determine if you're eligible to win a free pizza!\n");
            Console.WriteLine("Here are the rules:");
            Console.WriteLine("1. Your name must have at least 5 letters or it must not start with a vowel");
            Console.WriteLine("2. You must like pizza or you must have at least 3 friends who like pizza");
            Console.WriteLine("3. You must have never won free pizza before, or if you have, it was more than 2 weeks ago\n");

            // Variables for eligibility (initializing to default values)
            string name = null;
            string likePizza = null;
            int friendPizzaCount = 0;
            string hasWonPizza = null;
            int wonPizzaWeeks = 0;

            // Name
            Console.WriteLine("Enter your first name: ");
            name = Console.ReadLine();

            // -------------------------------------------------------------------------------------------------
            // ** BROKEN **
            // Use the debugger to determine what the issue is.
            // *************

            // Like pizza?  
            Console.Write("Do you like pizza? (yes/no): ");
            likePizza = Console.ReadLine().ToLower();
            ///LOGIC ERROR NEEDED TO BE AND 
            if (likePizza != "yes" && likePizza != "no")
            {
                Console.WriteLine("You did not enter a valid value!  You should have typed 'yes' or 'no'");
            }
            // -------------------------------------------------------------------------------------------------

            // How many friends like pizza?  Must be an integer
            Console.Write("How many of your friends like pizza? ");
            while (!int.TryParse(Console.ReadLine(), out friendPizzaCount))
            {
                Console.Write("Invalid input, please enter an integer: ");
            }

            // -------------------------------------------------------------------------------------------------
            // ** BROKEN **
            // Use the debugger to determine what the issue is.
            // *************

            // Previous winner?
            ///Wrong varaible in if statement
            Console.Write("Have you ever won free pizza before? (yes/no): ");
            hasWonPizza = Console.ReadLine().ToLower();
            if(hasWonPizza != "yes" && hasWonPizza != "no")
            {
                Console.WriteLine("You did not enter a valid value!  You should have typed 'yes' or 'no'");
            }
            // -------------------------------------------------------------------------------------------------

            // Only ask this question if the user has won free pizza before
            if (hasWonPizza == "y")
            {
                Console.Write("How many weeks ago did you win free pizza? ");
                while (!int.TryParse(Console.ReadLine(), out friendPizzaCount))
                {
                    Console.Write("Invalid input, please enter an integer: ");
                }
            }

            // -------------------------------------------------------------------------------------------------
            // ** BROKEN **
            // Use the debugger to determine what the issue is.
            // *************

            // NOTE:  To get the first letter of a string, you could do either:
            // stringVariable.Substring(0, 1); 
            // OR
            // stringVariable[0]  <-- Retrieves the 0th (first) character in the string

            // Make checking first letter easier
            name = name.ToUpper();

            // Determine if the user is eligible!
            ///Logic error in first part of if statement
            if (name.Length >= 5 || name[0] != 'A' || name[0] != 'E' || name[0] != 'I' || name[0] != 'O' || name[0] != 'U'
                && likePizza == "y" || friendPizzaCount >= 3 && hasWonPizza == "n" || wonPizzaWeeks >= 2)
            {
                Console.WriteLine("\nCongrats, you have been entered into the contest!");
            }
            else
            {
                Console.WriteLine("\nSorry, you are not eligible to win.");
            }
            // -------------------------------------------------------------------------------------------------
        }
    }
}
