using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

  
            Console.WriteLine(FindWord(s1,s2)); 
        }
        static int FindWord(string s1,string s2)
        {
            int result = -1;
            if (s1.Length >= s2.Length)
            {
                for (int i = 0; i <= s1.Length - s2.Length; i++)
                    if (s2 == s1.Substring(i, s2.Length))
                    {
                        result = i;
                        break;
                    }

            }
            return result;
        }
    }
}
