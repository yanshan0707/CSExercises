using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("put a phrase:");
            string a = Console.ReadLine();
            char[] put = a.ToArray();
            bool pali=false ;
            for(int i=0;i<put.Length/2;i++)
            {
                if (put[i] == put[put.Length - 1 - i])
                    pali = true;
            }
            if (pali == true)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");



            string b = a.ToUpper();
            char[] put1 = b.ToArray();
            char[] punc = new char[] { ',', '.', '#', '*' };
        }
    }
}
