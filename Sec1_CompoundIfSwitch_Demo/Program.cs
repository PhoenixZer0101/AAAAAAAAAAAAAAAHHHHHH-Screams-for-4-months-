using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Erin Cascioli
// 2/5/2020
// Demo: Compound Conditionals and Switch

namespace Sec1_CompoundIfSwitch_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------
            // Ask for a number, let user know if its valid
            // -----------------------------------------------------------
            Console.Write("Enter a number between 1 and 10: ");
            int userGuess = int.Parse(Console.ReadLine());

            // Determine if it's in range by using 2 compound conditionals
            if(userGuess >= 1 && userGuess <= 10)   // OR you could use: if (userGuess > 0 && userGuess < 11)
            {
                Console.WriteLine("Your number is in range");
            }
            else if (userGuess < 1 || userGuess > 10)   // OR you could use: if (userGuess <= 0 && userGuess >= 11)
            {
                Console.WriteLine("Your number is NOT in range");
            }

            // Switches are awesome, but not especially so for ranges.  
            // They work better for discrete values
            // Only ONE of the cases will execute, so no internal ranges are ok
            //   for example, case userGuess > 10  --> WON'T WORK
            // This switch has a bunch of fall-through cases, 
            //   so if the number is 1 - 10, output will display "in range"
            // But if the number is NOT 1 - 10, the default case will run
            //   and output will display "not in range"
            // Defaults are optional but do provide a "catch-all" case
            switch(userGuess)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("In range.");
                    break;
                default:
                    Console.WriteLine("Not in range");
                    break;
            }

            // Add some spacing in the console
            Console.WriteLine();


            // -----------------------------------------------------------
            // Ask for a country and age, let user know if they are of drinking age
            // -----------------------------------------------------------
            Console.Write("Which country do you live in? ");
            string country = Console.ReadLine().ToUpper().Trim();
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            // Compound conditional that checks the country and age of these 3 possibilities
            // Good practice to break up the conditions on separate lines for readability
            // AND you can put small, quick comments to the right of each condition that
            //   you can't do when they're all in one line
            //if ((country == "US" && age >= 21) || (country == "Jamaica" && age >= 18) || (country == "Germany" && age >= 16))  GROSS!!

            if ((country == "US" && age >= 21) ||           // US is 21
                (country == "JAMAICA" && age >= 18) ||      // Jamaica is 18
                (country == "GERMANY" && age >= 16))        // Germany is 16
            {
                Console.WriteLine("You can drink.");
            }
            else
            {
                Console.WriteLine("Sorry, no alcohol for you in public.");
            }
        }
    }
}
