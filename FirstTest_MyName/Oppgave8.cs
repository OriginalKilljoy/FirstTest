using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Oppgave8
    {
        int number1 = 8;
        int number2 = 10;
        bool sum30OrOne30 = false;

        public void Run()
        {
            if (number1 == 30 | number2 == 30 | number1 + number2 == 30)
            {
                sum30OrOne30 = true;
                Console.WriteLine("One of the numbers has a value of 30, or the sum of the numbers add up to 30");
            }
            else
            {
                sum30OrOne30 = false;
                Console.WriteLine("Neither of the numbers are 30, and they do not add up to be 30");
            }
        }
    }
}
