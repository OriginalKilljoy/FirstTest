using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Oppgave5
    {
        string returnText = "Denne metoden returner ingenting";

        public void ReturnNothing()
        {
            return;
        }

        public void Run()
        {
            Console.WriteLine(returnText);
        }
    }
}
