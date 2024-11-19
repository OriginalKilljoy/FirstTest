using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Oppgave6
    {
        int number1 = 8;
        int number2 = 10;
        private bool isEqual = false;

        public void Run()
        {
            if (number1 == number2)
            {
                isEqual = true;
                Console.WriteLine("The numbers are equal! Success!");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("The numbers are not equal...");
            }
        }
    }
}
