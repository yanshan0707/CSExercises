using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
                   

            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            Console.WriteLine(InString(s1,s2));
         }
           
        static bool InString(string s1,string s2)
        {
            bool contains = false;
            if (s1.Length >= s2.Length)
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)
                    if (s2 == s1.Substring(i, s2.Length))
                        contains = true;
            }
            return contains;
        }
    }
}
