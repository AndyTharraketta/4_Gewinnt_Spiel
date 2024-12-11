using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GewinntSpiel
{
    internal class LanguageMenu : Menu
    {
        public override void ToShow()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t-Willkommen bei 4 Gewinnt-");
            // Spielmodus Auswahl
            Console.WriteLine("\n\t\tOptionen\n\n\t-1-\tDeutsch\n\t-2-\tEnglisch\n\t-3-\tSpanisch\n\t-4-\tZurück zum Hauptmenü");
            Console.Write("\nAuswahl: ");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Console.WriteLine("Hier wird  ausgewählt");        // Platzhalter für Deutsch
                    break;
                case "2":
                    Console.WriteLine("Hier wird  ausgewählt");        // Platzhalter für Englsich
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
