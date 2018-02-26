using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class   Program
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
            double zweiterSummandalsZahl = Convert.ToDouble(zweiterSummand);

            //Summe bilden
            double Summe = Addiere(ersterSummandalsZahl,zweiterSummandalsZahl);

            //Ausgabe
            Console.WriteLine("Die Summe aus {1} und {2} ist: {0:F}", Summe, ersterSummand, zweiterSummand);
            WarteaufBenutzerEingabe();
        }

        static double Addiere(double ErsterSummand, double zweiterSummand)
        {
            double Summe = ErsterSummand + zweiterSummand;

            return Summe;

        }

        static void WarteaufBenutzerEingabe()
        {
            Console.WriteLine("Zum Beenden bitte RETURN drücken");
            Console.ReadLine();
        }
    }
}
