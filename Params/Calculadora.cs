using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    class Calculadora
    {
        public static int Sum(params int[] numeros)
        {
            int result = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                result += numeros[i];
            }

            return result;
        }
    }
}
