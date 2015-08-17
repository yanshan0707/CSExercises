using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("What is your name:  ");
            string name = Console.ReadLine();
            Console.Write("What is your gender,M or F:  ");
            string gen = Console.ReadLine();
            Console.Write("What is your age:  ");
            int age =Convert.ToInt32 (Console.ReadLine());
            if(gen =="M")
            {
              if(age<40)
              { 
                  Console.WriteLine("Good Morning,Mr  " + name);
              }
              else
              { 
                   Console.WriteLine("Good Morning,UNcle  " + name);
              }
            }
            else
            {
                if(age<40)
                {
                  Console.WriteLine("Good Morning,Ms  " + name);
                }
                else
                {
                    Console.WriteLine("Good Morning,UNty  " + name);
                }
            }
            
        }
    }
}