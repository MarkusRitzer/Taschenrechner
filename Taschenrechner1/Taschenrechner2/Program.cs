using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner1
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story: Als Benutzer möchte ich zwei Zahlen eingeben und die Summe berechenen lassen
            Console.Write("Gib bitte den ersten Summanden ein:");
            string ersterSummand = Console.ReadLine();
            Console.Write("Gib bitte den zweiten Summanden ein:");
            string zweiterSummand=Console.ReadLine();

            //Wandel Text in Zahl
            double ersterSummandalsZahl = Convert.ToDouble(ersterSummand);
            int zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            //Summe bilden
            double Summe = ersterSummandalsZahl + zweiterSummandalsZahl;

            //Ausgabe
            Console.WriteLine("Die Summe aus {1} und {2} ist: {0}", Summe, ersterSummand, zweiterSummand);
            Console.ReadLine();

        }
    }
}
