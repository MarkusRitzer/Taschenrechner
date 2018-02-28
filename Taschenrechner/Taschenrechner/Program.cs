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
            string ersteZahlalsString= HoleBenutzereingabe("Gib bitte die erste Zahl ein: ");
            string zweiteZahlalsString = HoleBenutzereingabe("Gib bitte die zweite Zahl ein: ");
            string operation=HoleBenutzerauswahl("Bitte wähle die Rechenoperation aus (+ oder -):");
            //Wandel Text in Zahl
            //TODO: Auslagern wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            double resultat = 0;

            switch (operation)
            {
                case ("+"):
                    //Summe bilden
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe aus {0} und {1} ist: {2}", ersteZahl, zweiteZahl, resultat);
                    break;
                case ("-"):
                    //Differenz bilden
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Differenz aus {0} und {1} ist: {2}", ersteZahl, zweiteZahl, resultat);
                    break;
                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl getroffen!");
                    break;
            }
            
            HoleBenutzereingabe("Zum Beenden bitte RETURN drücken");
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

        static string HoleBenutzerauswahl(string auswahltext)
        {
            Console.WriteLine(auswahltext);
            string eingabe = Console.ReadLine();
            return eingabe;
            
        }


        static string HoleBenutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string eingabe= Console.ReadLine();

            return eingabe;
        }

    }
}

