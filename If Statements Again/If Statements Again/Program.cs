using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Cill Narain
            ///2/3/2020
            ///Purpose: Finally If Statements!!! We're going to be using these guys in order to make a psuedo AI that senses things!!!

            ///First the Varaiables!
            string name;
            string userChoice;
            string userChoice2;
            string game;

            ///The inital questions...
            Console.Write("What is your character's name? ");
            name = Console.ReadLine().Trim().ToLower();
           
            Console.Write("Awesome! Would you like to play the game?");
            userChoice = Console.ReadLine().Trim().ToLower();
            ///Awesome! We're playing the game now!
            if (userChoice == "yes")
            {
                Console.WriteLine("Cool! Let's begin!!");
                Console.ReadLine();
                
                ///This bit here let's you know what options there are
                Console.WriteLine("Character: " + name);
                Console.WriteLine("Your options are: Play game, Eat food, Sleep, and bother Renee");
                Console.Write("What does " + name + " sense?");
                userChoice2 = Console.ReadLine().Trim().ToLower();
               
                game = Console.ReadLine().Trim().ToLower();

                ///The first choice, this one's nested since you have to pick which game you want to play!
                if (userChoice2 == "play game")
                {

                    Console.Write("What game would " + name + " like to play?");
                    game = Console.ReadLine().Trim().ToLower();
                    if (game == "lampblack")
                    {
                        Console.WriteLine("You decide to play a really fun game! You're having a really good time!!");
                    }
                    else if (game == "yiik")
                    {
                        Console.WriteLine("Your eyeballs have been tortured by the awful storyline and even worse graphics, press F for respect");
                    }

                }
                ///The second choice! Everyone loves food!!
                else if (userChoice2 == "eat food")
                {
                    Console.WriteLine("You decide that you're extremely hungry right now and grab the first thing from the fridge, its decent.");
                }
                ///The third choice!! Now if only that were true...
                else if (userChoice2 == "sleep")
                {
                    Console.WriteLine("You decide to go to sleep, your bed's super comfy so it doesn't take long for you to doze off!");
                }
                ///And the final choice!!! Renee is definitely not amused. She told me. "lol big facts" - Renee 2020 
                else if (userChoice2 == "bother renee")
                {
                    Console.WriteLine("You're extremely bored and decide to bother your mom friend Renee, she isn't amused.");
                }
                else
                {
                    Console.WriteLine("HEY!! THE COMPUTER CANNOT UNDERSTAND YOU!!! TYPE SOMETHING VALID!!!");
                }
            }
            ///If the user doesn't want to play the game, this message appears...
            else
            {
                Console.WriteLine("Awww, okay...");
            }

            


        }
    }
}
