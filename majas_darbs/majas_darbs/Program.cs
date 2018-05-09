using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace majas_darbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi banknotes lielumu, un uzzini, kas atteelots uz dolaara!");
            string ievade = Console.ReadLine();
            switch (ievade)
            {

                case "1":
                    Console.WriteLine("uz 1$ banknotes ir attelots George Washington");
                    break;
                case "2":
                    Console.WriteLine("uz 2$ banknotes ir attelots Thomas Jefferson");
                    break;
                case "5":
                    Console.WriteLine("uz 5$ banknotes ir attelots Abraham Lincoln");
                    break;
                case "10":
                    Console.WriteLine("uz 10$ banknotes ir attelots Alexander Hamilton");
                    break;
                case "20":
                    Console.WriteLine("uz 20$ banknotes ir attelots Andrew Jackson");
                    break;
                case "50":
                    Console.WriteLine("uz 50$ banknotes ir attelots Ulysses S. Grant");
                    break;
                case "100":
                    Console.WriteLine("uz 100$ banknotes ir attelots Benjamin Franklin");
                    break;
                default:
                    Console.WriteLine("Error! ievadiet pareizu banknotes lielumu ar cipariem!");
                    break;
            }
                Console.ReadLine();
        }
    }
}
