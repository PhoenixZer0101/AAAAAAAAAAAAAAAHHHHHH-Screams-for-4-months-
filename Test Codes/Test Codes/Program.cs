using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 3;
            switch (value)
            {
                case 4:
                    Console.WriteLine("First");
                    break;
                case 5:
                    Console.WriteLine("Second");
                    break;
                case 8:
                    Console.WriteLine("Third");
                    break;
                case 9:
                    Console.WriteLine("Fourth");
                    break;
                default:
                    Console.WriteLine("Fifth");
                    break;
            }




        }
    }
}
