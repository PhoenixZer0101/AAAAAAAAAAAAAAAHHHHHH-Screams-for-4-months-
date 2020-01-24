using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Data_Types_Again
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Cill Narain
            ///1/22/2020
            ///Purpose: We're finally using variables!!! This is to recreate a totally real and popular game that everyone loves.
            ///Here's all the variables that we're going to need for this exercise
            string name = "Echo";
            const int startingResources = 100;
            int currentResources = 100;
            int purchaseShip;
            int purchaseUpgrade;
            int alienNum;
            const int alienKillScore = 5;
            int missileNum;
            const int missileCost = 4;
            int stealGoods;
            int hangarSpace;

            ///First part
            Console.WriteLine(name + " is starting the game with " + startingResources + " resources.");
            Console.WriteLine(">> Current Resources: " + currentResources);
            Console.ReadLine();
            ///Second part includes a lot of math
            purchaseShip = 70;
            purchaseUpgrade = 16;
            Console.WriteLine(name + " purchased a ship for " + purchaseShip + " resources.");
            Console.WriteLine(name + " purchased a weapon upgrade for " + purchaseUpgrade + " resources.");
            currentResources = currentResources - purchaseShip - purchaseUpgrade;
            Console.WriteLine(">> Current Resources: " + currentResources);
            Console.ReadLine();
            ///Third part, our resources are nearly gone!
            missileNum = 3;
            Console.WriteLine(name + " purchased " + missileNum + " missiles to protect the ship");
            currentResources = currentResources - missileNum * missileCost;
            Console.WriteLine(">> Current Resources: " + (currentResources));
            Console.ReadLine();
            ///Fourth part, Violence and Chaos!
            alienNum = 7;
            Console.WriteLine(name + " obliterated " + alienNum + " aliens and earned " + alienNum * alienKillScore + " resources");
            currentResources = currentResources + alienNum * alienKillScore;
            Console.WriteLine(">> Current Resources: " + currentResources);
            Console.ReadLine();
            ///Fifth part, Yay! More resources!!
            stealGoods = 112;
            Console.WriteLine(name + " sold " + stealGoods + " resources worth of stolen goods.");
            currentResources = currentResources + stealGoods;
            Console.WriteLine(">> Current Resources: " + currentResources);
            Console.ReadLine();
            ///Sixth Part, here's to Vacation!
            hangarSpace = 20;
            Console.WriteLine(name + " leased a month of hangar space on Planet Xylew for " + hangarSpace + " resources.");
            currentResources = currentResources - hangarSpace;
            Console.WriteLine(">> Current Resources: " + currentResources);












        }
    }
}
