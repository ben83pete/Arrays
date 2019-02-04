using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class LookAtEachNumber
    {
        int?[] numbers = {1,2,3,null,4,5};
        int[] bowlingScores = { 22, 13, 28, 7, 23, 16, 20, 19, 26, 3 };

        

        public void BowlingGameScore()
        {
            {
                var total = 0;

                foreach (var nbr in bowlingScores)                
                {
                    total += nbr;
                }
                Console.WriteLine($"Total score is {total}");
            }


        }
        public void CheckNumbers()
        {
            foreach ( var I in numbers)
            {
                if (I == null)
                {
                    Console.WriteLine("Null");
                }
                else { 

                    var msg = (I % 2 == 0) ? "Even" : "Odd";
                    Console.WriteLine(msg);
                    
                }
            }
        }
    }
}
