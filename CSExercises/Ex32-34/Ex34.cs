using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 } };
            int sum=0;
         for(int student=0;student<=4;student++)
            {
                sum = 0;
                for (int subject = 0; subject <= 3; subject++)
                {
                    sum = sum + marks[student, subject];
                }
                Console.WriteLine(sum);
            }


            for (int student = 0; student <= 4; student++)
            {

                for (int subject = 0; subject <= 3; subject++)
                {
                    sum = sum + marks[student, subject];
                }
                
            }
            Console.WriteLine(sum / 20);


            for(int subject=0;subject <= 3; subject++)
            {
                sum=0;
                for(int student=0;student<=4;student++)
                    sum = sum + marks[student, subject];
                Console.WriteLine(sum);
            }
            
        }
    }
}
