using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            
            int[] A = new int[5]{86,35,41,49,89};
            for(int green=0;green<A.Length-1;green++)
            {
                for(int red=green+1;red<A.Length;red++)
                {
                    if (A[green]<A[red])
                    {
                        int temp = A[red];
                        A[red] = A[green];
                        A[green] = temp;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            
                Console.Write("{0}\t", A[i]);
        
            
        }
    }
}
