using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
                Console.WriteLine(hex(i));

        }
        static string hex(int n)
        {
            string[] b = new string[] { "A", "B", "C", "D", "E", "F" };
            int[] yushu = new int[10];
            int[] yushu1 = new int[yushu.Length];
            int zero = 0;
            string s = "";
            for (int i = 0; n != 0; i++)
            {
                yushu[i] = n % 16;
                n = n / 16;
            }
            for (int i = 0; i < yushu.Length; i++)
            {
                yushu1[yushu.Length - 1 - i] = yushu[i];
            }
            for (int i = 0; yushu1[i] == 0; i++)
                zero = i;
            for (int i = zero + 1; i < yushu1.Length; i++)
            {

                if (yushu1[i] <= 9)
                {
                    s = s + Convert.ToString(yushu1[i]);
                }
                else
                {
                    int a = yushu1[i] - 10;
                    s = s + b[a];
                }

            }
            return s;
        }

    }

   
}
  