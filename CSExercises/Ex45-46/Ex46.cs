using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = new int[50];
            int[] c = new int[a.Length];
            int occurrence = 0;
            Random r = new Random();
            for (int i = 0; i < 50; i++)
                b[i] = r.Next(0, 10);
            for (int i = 0; i < a.Length; i++)
            {
                occurrence = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] == a[i])
                        occurrence++;
                }
                c[i] = occurrence;
            }
            Console.WriteLine("Number\tCount");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine("{0}\t{1}", a[i], c[i]);

            string[] s = new string[a.Length];
            Console.WriteLine("Number");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+"   ");
                for (int j = 0; j < c[i]; j++)
                {
                    Console.Write("*");
                } Console.WriteLine();
            } 
            //int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //Random r = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //    int k = r.Next(0, 10);
            //    a[k]++;
            //}
            //Console.WriteLine("{0,-8}{1,-8}", "Number", "Count");
            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine("{0,-8}{1,-8}", i, a[i]);
            //Console.WriteLine("Number");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("{0,-6}", i);
            //    for (int j = 0; j < a[i]; j++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //int[] b = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //Random R = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    int k = R.Next(-5, 5);
            //    if (i <= 50)
            //        b[k + 5]++;
            //}
            }
        }
    }

