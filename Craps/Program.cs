using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craps
{
    class Program
    {
        static Random r = new Random();
        static int wins = 0, losses = 0;
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 10000000)
            {
                //Console.WriteLine("Press enter to roll");
                //Console.ReadLine();
                int roll = rollDie();
                switch (roll)
                {
                    case 2:
                    case 3:
                    case 12:
                        lose();
                        break;
                    case 7:
                    case 11:
                        win();
                        break;
                    default:
                        alternative(roll);
                        break;
                }
                count++;
            }
            Console.WriteLine("Wins: {0}  Losses {1}",wins,losses);
        }

        static int rollDie()
        {
            int roll = r.Next(1, 7) + r.Next(1, 7);
            //Console.WriteLine(roll);
            return roll;
        }

        static void alternative(int point)
        {
            //Console.WriteLine("Point is {0}. Press enter to roll",point);
            //Console.ReadLine();
            int roll = rollDie();
            if (roll == point)
            {
                win();
            }
            else if (roll == 7)
            {
                lose();
            }
            else alternative(point);
        }

        static void lose()
        {
            //Console.WriteLine("Thats a loss");
            losses++;
        }

        static void win()
        {
            //Console.WriteLine("Thats a win");
            wins++;
        }
    }
}
