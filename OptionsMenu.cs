using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GewinntSpiel
{
    internal class OptionsMenu : Menu 
    {
        public override void ToShow()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t-Willkommen bei 4 Gewinnt-");
            // Spielmodus Auswahl
            Console.WriteLine("\n\t\tOptionen\n\n\t-1-\tDesignauswahl\n\t-2-\tSprachauswahl\n\t-3-\tZurück zum Hauptmenü");
            Console.Write("\n\nAuswahl: ");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Menu designMenu = new DesignMenu();     // Auswahl Design 
                    designMenu.ToShow();
                    break;
                case "2":
                    Menu languageMenu = new LanguageMenu();     // Auswahl Sprache
                    languageMenu.ToShow();
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
