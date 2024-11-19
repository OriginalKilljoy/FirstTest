using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    internal class Conversation
    {
        public void Run()
        {
            Console.WriteLine("Hello Traveller! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}! This is my tavern, The Singing Bard. What would you like to drink?");
            string drink = Console.ReadLine();
            Console.WriteLine($"Excelent choice, one {drink} coming right up.");
            Console.WriteLine($"So tell me {name}, where are you from?");
            string home = Console.ReadLine();
            Console.WriteLine($"Is that so? Well you must be quite wary after having travelled all the way from {home}");
            Console.WriteLine("Well as the name of my tavern suggests, we have some very talented Bards performing here. Maybe you can put in a request.");
            Console.WriteLine("What is your favorite song?");
            var song = Console.ReadLine();
            Console.WriteLine($"Perfect! Troop, play {song}!");
            Console.WriteLine($"Now here comes an important question {name}, what is your favorite meal?");
            string food = Console.ReadLine();
            Console.WriteLine($"Oh this cannot be a coincidence! It just so happens we are serving {food} tonight! Let me grab you a serving.");

        }
    }
}
