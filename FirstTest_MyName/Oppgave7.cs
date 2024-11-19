using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Oppgave7
    {
        int number1 = 8;
        int number2 = 10;

        public int Run()
        {
            if (number1 == number2)
            {
                int newNumber1 = number1 * number2;
                Console.WriteLine($"The numbers are equal, and multiplied they are {newNumber1}");
                return newNumber1;
            }
            else
            {
                int newNumber2 = number2 + number1;
                Console.WriteLine($"The numbers are not equal, and the sum of them is {newNumber2}");
                return newNumber2;
            }
        }
    }
}
