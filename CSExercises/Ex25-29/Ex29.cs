using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = 1; i <a; i++)
            {
                if(a%i==0)
                {
                    sum = sum + i;
                }
                
            }
            if (sum==a)
            {
                Console.WriteLine("perfect number");
            }
            else
                Console.WriteLine("not perfect number");
            Console.Read();
        }
    }
}
