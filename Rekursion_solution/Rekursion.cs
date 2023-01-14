using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursion_solution
{
     public class Rekursion
    {
        public static int fakultaet(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return fakultaet(number - 1) * number;
        }

        public static int fibonacci(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return fibonacci(number - 1) + fibonacci(number - 2);
        }
    }
}
