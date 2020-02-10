using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_Cill_Narain
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Story time!!! Here are the variables!!
            ///For the first input
            string input1;
            ///Second input
            string input2;
            ///Kindness level! This changes throughout the story
            int kindnessLevel = 100;
            ///truth determines the second part's output!!
            bool truth;
            ///Only a specific choice is needed to trigger this choice!
            string talkToSpecialPerson;
  
            ///Here's the start of the story!!!
            Console.WriteLine("Welcome to the game!! Let's walk through a short story okay?");
            Console.ReadLine();
            Console.Write("You woke up to the sound of a phone call at approximately 8AM in the morning, " +
                "you tiredly look to see the caller ID, \nit was Renee, your good and sometimes annoying friend, do you pick up the phone? YES or NO ");
            input1 = Console.ReadLine().Trim().ToLower();
            ///And our first choice!!
            if (input1 == "yes")
            {
                Console.ReadLine();
                Console.WriteLine("Despite the fact that you're tired and don't want to hear it, you decide that its a necessary evil and pick up the \nphone. " +
                    "Your Kindness level is {0} ", kindnessLevel + 10);
            }
            else if (input1 == "no")
            {
                Console.ReadLine();
                Console.WriteLine("You really don't want to hear the sound of Renee's voice right now, and you're tired, you don't pick up the phone and " +
                    "\nsleep for about 10 more minutes. Your Kindness level is {0} " , kindnessLevel - 25);
            }
            else
            {
                Console.WriteLine("Game.exe has an error, now crashing...");
            }
            ///Here's the Second Choice!!
            Console.ReadLine();
            Console.Write("After waking up and going to your first class, Renee notices your tired demeanor, she asks if you are alright, \ndo you TELL THE TRUTH? ");
            input2 = Console.ReadLine().Trim().ToLower();
            if (input2 == "tell truth")
            {
                Console.ReadLine();
                truth = true;
                Console.WriteLine("You decide to tell her the truth that you feel really tired and you won't be able to make it to her math class today. " +
                    "\n Your Kindness level is {0} ", kindnessLevel - 10);
            }
            else if (input2 == "lie")
            {
                Console.ReadLine();
                truth = false;
                Console.Write("You lie and say that you're fine and that you'll be at her math class today, as you're walking to class, " +
                    "\nyou bump into a very special person, and they notice you, do you TALK to them or can you just WAVE? ");
                ///if you choose lie, then these prompts occur!!!
                talkToSpecialPerson = Console.ReadLine().Trim().ToLower();
                if (input2 == "lie" && talkToSpecialPerson == "talk")
                {
                    Console.ReadLine();
                    Console.WriteLine("You decide to talk to them and end up having a awkward but productive conversation! Your Kindness level is {0}", kindnessLevel + 5);
                }
                if (input2 == "lie" && talkToSpecialPerson == "wave")
                {
                    Console.ReadLine();
                    Console.WriteLine("You become extremely flustered and can only manage to give a small wave, they seem a bit sad. Your Kindness level is {0}", kindnessLevel - 25);
                }
            }
            else
            {
                Console.WriteLine("Game.exe has an error, now crashing...");
            }
            ///Here's the last choice and ending!!!!
            Console.ReadLine();
            Console.Write("You go home after a while and realize that you have a lot of time on your hands...");
            ///If the kindness level is less than or equal to these amounts, then the following endings will happen
            if (kindnessLevel <= 50)
            {
                Console.WriteLine("You feel really tired and slept for the next hour or so");
            }
            else if (kindnessLevel <= 65)
            {
                Console.WriteLine("You feel a bit tired, but managed to do some homework!");
            }
            else if (kindnessLevel <= 100)
            {
                Console.WriteLine("You decide to do some homework, \n" +
                    "and got a lot more than you expected done!");
            }
            else if (kindnessLevel <= 115)
            {
                Console.WriteLine("You decide to do your homework, you got all of it done!!");
            }

           
        }
    }
}
