using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            //caso base o condicional
            //caso general
            return num * CalcularFactorial(num - 1);
        }
    }
}
