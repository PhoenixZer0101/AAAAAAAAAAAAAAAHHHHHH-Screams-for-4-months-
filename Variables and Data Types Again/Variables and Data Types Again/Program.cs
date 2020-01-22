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
            Console.WriteLine(name + " purchased a ship for " + purchaseShip + " resources.");
            purchaseUpgrade = 16;
            Console.WriteLine(name + " purchased a weapon upgrade for " + purchaseUpgrade + " resources.");
            Console.WriteLine(">> Current Resources: " + (currentResources - purchaseShip - purchaseUpgrade));
            Console.ReadLine();
            ///Third part, our resources are nearly gone!
            currentResources = 14;
            missileNum = 3;
            Console.WriteLine(name + " purchased " + missileNum + " missiles to protect the ship");
            Console.WriteLine(">> Current Resources: " + (currentResources - missileNum * missileCost));
            Console.ReadLine();
            ///Fourth part, Violence and Chaos!
            currentResources = 2;
            alienNum = 7;
            Console.WriteLine(name + " obliterated " + alienNum + " aliens and earned " + alienNum * alienKillScore + " resources");
            Console.WriteLine(">> Current Resources: " + (currentResources + alienNum * alienKillScore));
            Console.ReadLine();
            ///Fifth part, Yay! More resources!!
            currentResources = 37;
            stealGoods = 112;
            Console.WriteLine(name + " sold " + stealGoods + " resources worth of stolen goods.");
            Console.WriteLine(">> Current Resources: " + (currentResources + stealGoods));
            Console.ReadLine();
            ///Sixth Part, here's to Vacation!
            currentResources = 149;
            hangarSpace = 20;
            Console.WriteLine(name + " leased a month of hangar space on Planet Xylew for " + hangarSpace + " resources.");
            Console.WriteLine(">> Current Resources: " + (currentResources - hangarSpace));












        }
    }
}
