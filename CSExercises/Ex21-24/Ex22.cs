using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input an integer A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input an integer B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c=a*b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            int HCF = a;
            int LCM = c / HCF;
            Console.WriteLine("HCF is {0} \nLCM is{1}", HCF, LCM);
            Console.ReadLine();

        }
    }
}
