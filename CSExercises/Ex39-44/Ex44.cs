using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c1=Convert.ToChar(Console.ReadLine());
            char c2 = Convert.ToChar(Console.ReadLine());
            
            int occure=0;
            for(int i=0;i<s.Length;i++)
            {
                if (s.Substring(i, 0) == Convert.ToString(c1))
                 occure++;   

            }
            int[] position = new int[occure];
            for(int i=0;i<s.Length;i++)
            {
                if (s.Substring(i, 0) == Convert.ToString(c1))
                    position[i] = i;
            }
            
       
        }
    }
}
