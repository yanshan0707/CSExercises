using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("put a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            double g = r.Next(1, n);
          


            Console.WriteLine("the guess of the PC is {0}", g);
            do
            {
                if (g * g == n)
                {
                    Console.WriteLine("the guess {0} is correct", g);
                }
                else
                {
                    g = (g + n / g) / 2;
                }
            } while (g * g>= n + 0.00001 || g * g <= n - 0.00001);
            Console.WriteLine("the square root is approximately {0:0.00000}", g);
            Console.WriteLine(g * g);

        }
    }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
