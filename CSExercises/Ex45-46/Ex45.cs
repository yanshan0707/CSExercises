using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            double b = Convert.ToDouble(Console.ReadLine());
            double a = b * 100;
            //int a = (Convert.ToInt32(Console.ReadLine())) * 100;
            for(int i=0;i<Math.Floor(a/100);i++)
                Console.WriteLine("100c");
            for(int i=0;i<Math.Floor(a%100/50);i++)
                Console.WriteLine("50c");
            for (int i = 0; i < Math.Floor(a%100%50/20); i++)
                Console.WriteLine("20c");
            for (int i = 0; i < Math.Floor(a % 100 % 50%20 / 10); i++)
                Console.WriteLine("20c");
            for (int i = 0; i <Math.Floor( a%100%50%20%10/5); i++)
                Console.WriteLine("5c");

        }
    }
}
