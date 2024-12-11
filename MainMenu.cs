using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4GewinntSpiel
{
    internal class MainMenu : Menu
    {
        public override void ToShow() 
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t-Willkommen bei 4 Gewinnt-");
                // Hauptmenü Auswahl
                Console.WriteLine("\n\t\tHauptmenü\n\n\t-1-\tSpielmodus\n\t-2-\tOptionen\n\t-3-\tBeenden");
                Console.Write("\n\nAuswahl: ");
                string select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Menu gameModeMenu = new GameModeMenu();
                        gameModeMenu.ToShow();        // Auswahl Spielmodus
                        break;
                    case "2":
                        Menu optionsMenu = new OptionsMenu();      // Auswahl Optionen
                        optionsMenu.ToShow();
                        break;
                    case "3":
                        Console.WriteLine("\n\t\t    Spiel beendet\n\t\tBis zum nächsten Mal!");     // Programm wird beendet (Leerzeichen für die Optik^^) 
                        Console.ResetColor();
                        return;
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
}
