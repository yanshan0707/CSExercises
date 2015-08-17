using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input tha marks :  ");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("**Error");
            }
            switch (mark / 10)
              {
                case 10:
                case 9:
                case 8:
                    Console.WriteLine("You scored {0} marks which is A grade.",mark);
                    break;
                case 6:
                case 7:
                    Console.WriteLine("You scored {0} marks which is B grade.",mark);
                    break;
                case 4:
                case 5:
                     Console.WriteLine("You scored {0} marks which is C grade.",mark);
                    break;
                default:
                    Console.WriteLine("You scored {0} marks which is F grade.",mark);
                    break;

             }
        
        
        }
    }
}