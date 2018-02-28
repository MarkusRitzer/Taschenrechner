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
            // Beide Summanden einlesen
            string ersteZahlalsString= Benutzereingabe("Gib bitte die erste Zahl ein: ");
            string zweiteZahlalsString = Benutzereingabe("Gib bitte die zweite Zahl ein: ");

            //Wandel Text in Zahl
            //TODO: Auslagern wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            //Summe bilden
            double Summe = Addiere(ersteZahl,zweiteZahl);

            //Ausgabe
            Console.WriteLine("Die Summe aus {1} und {2} ist: {0:F}", Summe, ersteZahl, zweiteZahl);
            WarteaufBenutzerEingabe();
        }

        static double Addiere(double ErsterSummand, double zweiterSummand)
        {
            double Summe = ErsterSummand + zweiterSummand;

            return Summe;

        }

        static double Subtrahiere(double minuend, double subtrahent)
        {
            double subraktion = minuend - subtrahent;
            return subraktion;

        }

        static void WarteaufBenutzerEingabe()
        {
            Console.WriteLine("Zum Beenden bitte RETURN drücken");
            Console.ReadLine();
        }

        static string Benutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string eingabe= Console.ReadLine();

            return eingabe;
        }

    }
}
