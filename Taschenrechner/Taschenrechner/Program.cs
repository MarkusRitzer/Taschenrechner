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
            char auswahl=BenutzerAuswahl();
            //Wandel Text in Zahl
            //TODO: Auslagern wenn Struktur umfangreicher geworden ist
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsString);

            //Summe bilden
            double Summe = Addiere(ersteZahl,zweiteZahl);

            //Ausgabe
            Console.WriteLine("Die Summe aus {1} und {2} ist: {0:F}", Summe, ersteZahl, zweiteZahl);
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

        static char BenutzerAuswahl()
        {
            Console.WriteLine("Bitte Auswählen ob Summe oder Differenz gebildet wird (+ oder -):");
            string eingabe = Console.ReadLine();
            char zeichen= Convert.ToChar(eingabe);
            return zeichen;
            
        }


        static string HoleBenutzereingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string eingabe= Console.ReadLine();

            return eingabe;
        }

    }
}

