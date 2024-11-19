using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Oppgave4
    {
        int numberValue1 = 28;
        int numberValue2 = 44;

        public int ReturnAddedNumber(int number1, int number2)
        {
            return number1 + number2;
        }

        public void Run()
        {
            Console.WriteLine($"Summen av {numberValue1} + {numberValue2} blir {ReturnAddedNumber(numberValue1, numberValue2)}");
        }

    }
}
