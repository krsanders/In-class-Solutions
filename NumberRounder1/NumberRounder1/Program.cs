using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberRounder1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("The nearest round number is: " + NumberRound(41));
        Console.ReadKey();
        }
        // 1 % 5 = 1. Round down
        // 2 % 5 = 2  Round down
        // 3 % 5 = 3  Round up
        // 4 % 5 = 4  Round up
        // 5 % 5 = 0  NO rounding in either direction
        // 6 % 5 = 1  Round down
        // 7 % 5 = 2  Round down
        //...for 8 and 9 until 10 and etc.

        static int NumberRound(int numberToRound)
        
        int remainder = numberToRound % 5;

        if (remainder >= 3)
        {
        // Round UP
        numberToRound = numberToRound += (5 - remainder);
        return numberToRound;
        }
        else
        {
        numberToRound = numberToRound - remainder;
        return numberToRound;
        }
        return 0;
    
    }
}
