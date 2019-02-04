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
        int[] grades = { 86, 97, 82, 91, 97, 82, 96, 81, 86, 97, 75, 99 };


        public void TotalSales()
        {   // Total Sales sum
            // largest sale
            double[] sales = { 428.14, 635.15, 923.60, 400.95, 823.50, 434.65, 911.34, 759.36 };
            double total = 0;
            double  higestSale = 0;

            foreach (var S in sales)
            {
                total += S;

                if (S > higestSale) // if the # in the array is larger than variable higestsale, then make that number the new Highest sale.
                {
                    higestSale = S;
                }
            }
            Console.WriteLine($"Total of all Sales = {total}");
            Console.WriteLine($"The Higest sale is {higestSale}");
            Console.ReadKey();
        }


        public void Squares()
        {// square each number and add them all together
            int[] squares = { 12, 9, 2, 3, 13, 6, 10, 12, 14 };

            var total = 0;
            
            foreach (var idx in squares)
            {                
                total += (idx * idx);  // multiply idx * idx and then add it to the total
            }

            Console.WriteLine($"Total Squares = {total}");
            Console.ReadKey();
        }



        public void RandomNumbers()
        {// add together only the numbers that are divisable by 3
            int[] rndNbrs = { 77, 85, 43, 69, 99, 50, 24, 23, 76, 62, 58, 70, 47, 87, 22, 20, 52, 6, 34, 92 };

            var total = 0;

            foreach (var nbr in rndNbrs)
            {                                
                if (nbr % 3 == 0)  // if the # is divisable by 3
                {
                    total += nbr;  // then add the number to the total
                }                                            
            }
            Console.WriteLine($"{total}");
            Console.ReadKey();
        }


        public void Grades()
        {
            var total = 0;
            var count = 0;

            foreach (var grade in grades)
            {
                total += grade;  // add all the grades together
                count++;  // counts how many grades were added together
            }                 
                
            Console.WriteLine($"Grade average is {total / count}");
        }



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
