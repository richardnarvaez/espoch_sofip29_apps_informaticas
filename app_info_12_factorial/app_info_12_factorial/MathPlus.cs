using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_info_12_factorial
{
    public class MathPlus
    {
        public static int factorial(int numb)
        {
            int factorial_total = 1;
            while (numb > 1)
            {
                factorial_total *= numb;
                numb -= 1;
            }
            return factorial_total;
        }
        public static bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }
    }
}
