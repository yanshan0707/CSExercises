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
             
             Console.Write("after being sorted,the report of marks will be in the descending order : \n"); 
             for (i = 0; i < 5; i++) 
             {
                 for (j = i + 1; j < 5; j++)
                 {
                     if (mark[j] > mark[i])
                     {
                         temp = mark[j];
                         mark[j] = mark[i];
                         mark[i] = temp;
                         temp1 = name[j];
                         name[j] = name[i];
                         name[i] = temp1;
                     }
                 }
                 Console.Write("{0}\t{1}\n", name[i],mark[i]);                            
             }

             Console.Write("after being sorted,the report of names will be in the alphabetically order : \n");
             for (i = 0; i < 5; i++)
             {
                 for (j = i + 1; j < 5; j++)
                 {
                     if (name[j].CompareTo(name[i])==-1)
                     {
                         temp = mark[j];
                         mark[j] = mark[i];
                         mark[i] = temp;
                         temp1 = name[j];
                         name[j] = name[i];
                         name[i] = temp1;
                     }
                 }
                 Console.Write("{0}\t{1}\n", name[i], mark[i]);
             } 
        }
    }
}
