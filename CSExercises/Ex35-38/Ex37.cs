using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please input a phrase");
            string s = Console.ReadLine();
            string[] a = s.Split(new char[]{',','.','!',' '},StringSplitOptions.RemoveEmptyEntries);
           
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i].Substring(0, 1).ToUpper() + a[i].Substring(1);
                Console.Write(a[i]+" ");
            }   
        }
    }
}
