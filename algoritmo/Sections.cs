using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoritmo
{
    public class Sections
    {
        public string problem1(string text)
        {
            if (text.Length == 0)
            {
                return text;
            }

            if (text.Length % 2 == 0)
            {
                //extraendo el primer y segundo valor del divisible entre 2
                var primer = text.Substring((text.Length / 2) - 1, 1);
                var segundo = text.Substring(text.Length / 2, 1);
                return primer + segundo;
            }
            else
            {
                //extraendo el primer mas 1, valor del divisible entre 2
                var segundo = text.Substring(text.Length / 2, 1);
                return segundo;
            }
        }

        public string problem2(int value1, int value2)
        {
            List<string> result = [];
            int divisor = 1;
            int countDivisor = 0;
            //bucle contador con paramateos de entrada
            while (value1 <= value2)
            {
                //bucle contador usando divisor para obtener divisibles
                while (divisor <= value1)
                {
                    if ((value1 % divisor) == 0)
                    {
                        countDivisor++;
                    }
                    divisor++;
                }
                if (countDivisor == 2)
                {
                    //acumulador
                    result.Add(value1.ToString());
                }
                value1++;
                divisor = 1;
                countDivisor = 0;
            }

            return String.Join(" ", result);
        }
    }
}