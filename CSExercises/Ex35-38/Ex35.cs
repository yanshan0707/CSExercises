using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();
            char [] a = phrase.ToArray();
            char [] b = new char[] { 'a', 'e', 'i', 'o', 'u'};
            int  [] c = new int[b.Length];
            int total = 0, total_a = 0;
            for(int i=0;i<b.Length;i++)
            {
                total_a = 0;
                for(int j=0;j<a.Length;j++)
                {
                    if (a[j]==b[i])
                    {
                        total++;
                        total_a++;
                    }
                }
                c[i] = total_a;
                Console.WriteLine("Number of {0}:{1}",b[i],c[i]);
               
            }
            Console.Write("Total number of vowels:{0}", total);

           

        }
    }
}
