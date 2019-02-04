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
