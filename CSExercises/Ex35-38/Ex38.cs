using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            
             int i,j,max,temp,min=0; 
             string temp1; 
             string[] name=new string []{"John","Venkat","Mary","Victor","Betty"}; 
             int[] mark=new int []{63,29,75,82,55}; 
             Console.Write("Name\tMark\n"); 
             for (i = 0; i < 5; i++) 
                  Console.Write(name[i] + "\t" + mark[i] + "\n"); 
             max = 0; 
             Console.Write("after being sorted,the report of marks will be in the descending order : \n"); 
             for (i = 0; i < 5; i++) 
             { 
                 for (j = i + 1; j < 5; j++)                 
                 {
                    if (mark[j] > mark[max]) 
                         max = j;                 
                 } 
                 temp = mark[max]; 
                 mark[max] = mark[i]; 
                 mark[i] = temp;

                 

                 Console.Write("{0}\t", mark[i]);                            
             }              
            Console.Write("\n"); 
 
        }
    }
}
