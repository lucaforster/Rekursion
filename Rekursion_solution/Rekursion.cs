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
            if (number == 1)
            {
                return 1;
            }
            if (number == -1)
            {
                return -1;
            }
            return fakultaet(number - 1) * number;
        }

        public static int fibunaccis(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
           
            if (number == 1)
            {
                return 1;
            }
            return fibunaccis(number - 1) + fibunaccis(number - 2);
        }
    }
}
