using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Oppgave1
    {
        public void Run()
        {
            Console.WriteLine("Hei, hva heter du?");
            string answer = RunInput();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Velkommen {answer}!");
        }

        private string RunInput()
        {
            var input = Console.ReadLine();
            return input;
        }
    }
}
