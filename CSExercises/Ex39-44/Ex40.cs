using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
           for(int i=1;i<26;i++)
           {
               Console.WriteLine(SQT(i));
               
           }
              
        }
         static double SQT(int n)
        {
            Random r = new Random();
            double g = r.Next(1, n);
            bool guessright = false;
            Console.WriteLine("the guess of the PC is {0}", g);
            do
            {
                if (g * g == n)
                {
                    guessright = true;
                    //return g;
                    //break;
                }
                else
                {   
                    g = (g + n / g) / 2;
                }
            } while (g * g >= n + 0.00001 || g * g <= n - 0.00001);
            //return g;

            if (guessright == true)
            {
                Console.WriteLine("the guess {0} is correct", g);
            }
            else
                Console.WriteLine("the square root is approximately {0:0.00000}", g);
            return g;
        }
    }
}
