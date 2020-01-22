using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statements_and_Expressions_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Cill Narain
            ///1/17/2020
            ///Purpose: Using Statements and Expressions to create an RPG character, Oh joy!!!
            Console.WriteLine("Name: CoolGuyAvi.EXE");
            ///I had no idea what to name these levels, so I went back to a meme my brother and I made up while playing Secret of Mana for the Umpteenth time.

            ///First one is getting 20 percent of 50, which should be 10!
            Console.WriteLine("Rad levels: " + (0.2 * 50));
            ///Next one is taking that number, and dividing it by 2! This should give you 5
            Console.WriteLine("Chad levels: " + (0.2 * 50 / 2));
            ///Third one is 7, How lucky!!
            Console.WriteLine("Brad levels: " + 7);
            ///Fourth one is the second and the third results added together, and then subtracted by 2, so it should be 7 + 5 / 2!!
            Console.WriteLine("Kyle Levels: " + (0.2 * 50 / 2 + 7 - 2));
            ///Finally, we add them all together to get the fifth one, which should be 18!!
            Console.WriteLine("Annoying Younger Sister Levels: " + (50 -
                ((0.2 * 50)
                + (0.2 * 50 / 2) + 7
                + (0.2 * 50 / 2 + 7 - 2))));
            Console.WriteLine("Total Points: 50");

            Console.WriteLine(15 % 7);


        }
    }
}
