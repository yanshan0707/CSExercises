using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("put an integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 1; i <= a; i++) 
            {
                         if (a % i == 0) 
                         Console.WriteLine(i); 

            }
            


        }
    }
}
