using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input the three sides a,b,c");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int s = (a + b + c) / 2;
            double area=0;
            if(a+b>c&&a+c>b&&b+c>a)
            {
                area= Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("the area is {0}", area);
            }
            else
            {
                Console.WriteLine("It is not a triangle");
            }
            
        }
    }
}