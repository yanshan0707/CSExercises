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


            Console.WriteLine("put a phrase:");
            string c = Console.ReadLine();
            string b = c.ToUpper();
            char[] put1 = b.ToArray();
            char[] punc = new char[] { ',', '.', '#', '*',' ' };
            char[] put2 = new char[put1.Length];
            bool ok = false;
            for(int i=0;i<put1.Length;i++)
            {
                for(int j=0;j<punc.Length;j++)
                {
                    if (put1[i] != punc[j])
                        ok = true;
                }
                if (ok == true)
                    put2[i] = put1[i];
            }
             for(int i=0;i<put2.Length/2;i++)
            {
                if (put2[i] == put2[put1.Length - 1 - i])
                    pali = true;
            }
            
            if (pali == true)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");


        }
    }
}
