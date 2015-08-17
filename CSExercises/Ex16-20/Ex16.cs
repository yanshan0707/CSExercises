using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("input your name ");
            string name = Console.ReadLine();
            Console.Write("What is your gender  (F or M) :");
            string gen = Console.ReadLine();

            if (gen == "F") 
            { 
                Console.Write("Good Morning  Ms {0}",name);
            }
            else if(gen== "M")
            {
                Console.Write("Good Morning  Mr {0}",name);
            }
             else
            {
                Console.WriteLine("an error gender");
            }



        }
    }
}