using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV: ");
            int tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for TV: ");
            int dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for TV: ");
            int mp3 = Convert.ToInt32(Console.ReadLine());
            int a = 900 * tv + 500 * dvd + 700 * mp3;
            if (a <=5000)
            {
                Console.WriteLine("Total price for this order is {0:c}", a);
            }

            
        }
    }
}