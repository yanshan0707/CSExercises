using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("All the prime number from 5 to 1000 are ");
            int b;
            for(int a=5;a<=1000;a++)
            {
                for (b = 2; b < a; b++)
                {
                    if (a % b == 0)
                        break;
                    
                        
                }
                if(a==b)
                Console.WriteLine(a);
            }
            
        }
    }

 }