using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int max, min, sum,average;
            int[] sales = new int[12];
            for(int i =0;i<=11;i++)
            {
                Console.WriteLine("Enter sales for month {0}", i);
                sales[i]=Convert.ToInt32(Console.ReadLine());
            }
            max = min =sum= 0;
            for(int i=0;i<=11;i++)
            {
                if (sales[max] < sales[i])
                    max=i;
                if (sales[min]> sales[i])
                    min = i;
                sum = sum + sales[i];
                average = sum / 12;

            }
            average = sum / 12;
            
            Console.WriteLine("Maximun sales :{0}\n Minimum sales :{1}\nAverage sales:{2}", max, min,average);
            
            
        }
    }
}
