using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class ArrayOfIntegers
    {
        private int[] integers = new int[10];

        private int Sum()
        {
            var total = 0;
                            
            for (var idx =0; idx <10; idx++) // condition idx <10 is because the array only has 10 intgers
            {
                total += integers[idx];
            }
            return total;
        }

        public void Add(int index, int value)
        {
            integers[index] = value;
        }
        public int Get(int index)
        {
            return integers[index];
        }
        public void Print()
        {
            var comma = "";
            var total = 0;
            foreach ( var i in integers)
            {
                total += i;  // total starts at 0, += will add i into toatl and then add the next i from array

                Console.Write($"{comma} {i}"); // this print line prints all the integers in the array
                comma = " +";
                
            }
            Console.WriteLine(" =" + total);
        }
    }
}
