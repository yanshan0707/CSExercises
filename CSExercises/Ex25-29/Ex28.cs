using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put an integer : ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool prim = true;
            for(int i=2;i<a;i++)
            {
                if (a % i == 0)
              prim=false;
            }
            if(prim==false)
            Console.WriteLine("Not prime");
            else
                    Console.WriteLine("prime");
            
        }
    }
}
