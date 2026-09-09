using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public int CalcularFactorial(int num)
        {//caso base o condicional
            if (num == 1)
            {
                return 1;  
            }
            
            //caso general
            //cambios 
            return num * CalcularFactorial(num - 1);
        }
    }
}
