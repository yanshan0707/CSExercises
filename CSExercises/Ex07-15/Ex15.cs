using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input a three-digit integer");
            int a = Convert.ToInt32(Console.ReadLine());
            bool arms = Arms(a);
            if(arms==true)
                Console.WriteLine("It is an Armstrong number!");
            else
                Console.WriteLine("It isn't an Armstrong number!");

        }
        static bool Arms(int a)
        {
            double b = Math.Pow(a / 100, 3);
            double c = Math.Pow(a%100/10,3);
            double d = Math.Pow(a%10, 3);
            bool arms = false;
            if (b + c + d == a)
                arms = true;
            return arms;
        }
    }   
 


}