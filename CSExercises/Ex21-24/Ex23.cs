using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(1, 10);
            int guess,i=1;
            do
            {
                Console.Write("guess what:");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == a)
                {
                    Console.WriteLine("Congradulations, you have tried {0} times", i);
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine("try again: ");
                }



            } while (guess != a);
            if (i < 3)
            {
                Console.WriteLine("you are a wizard");
            }
            else if (i >= 3 && i < 6)
            {
                Console.WriteLine("you are good guess");
            }
            else
            {
                Console.WriteLine("you are lousy");
            }
                



            
        }
    }
}
