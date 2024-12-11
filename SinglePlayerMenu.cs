using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GewinntSpiel
{
    internal class SinglePlayerMenu : Menu
    {
        public override void ToShow()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t-Willkommen bei 4 Gewinnt-");
            // Spielmodus Auswahl
            Console.WriteLine("\n\t\tSpiel Modus\n\n\t-1-\tSpiel starten\n\t-2-\tEinstellung\n\t-3-\tZurück zum Hauptmenü");
            Console.Write("\n\nAuswahl: ");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("Spiel starten");      // Platzhalter zum starten des Spiels
                    break;
                case "2":
                    Console.WriteLine("Einstellung");        // Platzhalter für die Spiel Einstellung (z.B. Schwierigkeitsgrad)
                    break;
                case "3":
                    return;     // zurück zum Hauptmenü
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\t\tFalsche Eingabe");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\tTaste drücken zum fortsetzten");
                    Console.ReadKey();
                    break;
            }
        }

    }
}
