using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int a;
            do
            {
                Console.Write("Enter an integer:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 88)
                    Console.WriteLine("Lucky you!");

            } while (a != 88);
        }
    }
}

















                   
            
