using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Cill Narain
            ///2/3/2020
            ///Purpose: Ah yes switch statements, and also more boolean operators, what fun!!
            ///So as always we should start off with the variables.
            int cardNum;
            string cardSuit;
            string faceCard;
            int faceCardNum;

            Console.Write("Enter a card number: ");
            cardNum = int.Parse(Console.ReadLine());

            Console.Write("Enter a card suit: ");
            cardSuit = Console.ReadLine().Trim().ToLower();

            if (cardNum >= 2 && cardNum <= 10)
            {
                Console.WriteLine("The card value " + cardNum + " is valid");
            }
            else
            {
                Console.WriteLine("The card number " + cardNum + " is invalid");
            }

            if (cardSuit == "spades" || cardSuit == "hearts" || cardSuit == "clubs" || cardSuit == "diamonds")
            {
                Console.WriteLine("The card suit " + cardSuit + " is valid.");
            }
            else
            {
                Console.WriteLine("The provided card suit " + cardSuit + " is invalid");
            }





        }
    }
}
