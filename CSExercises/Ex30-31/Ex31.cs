using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("All the perfect number from 1 to 1000 are ");
            int sum;
            for(int a =1;a<=1000;a++)
            {
                sum = 0;
                for(int b =1;b<a;b++)
                {
                    if (a % b == 0)
                        sum = sum + b;


                }
                if (sum == a)
                 Console.WriteLine(a);
            }
        }
    }
}
