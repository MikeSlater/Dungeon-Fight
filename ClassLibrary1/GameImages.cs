using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameImages
{
    public class GameImages
    {
        public static void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("    ___                                        ___ _       _     _   ");
            Console.WriteLine("   /   \\_   _ _ __   __ _  ___  ___  _ __     / __(_) __ _| |__ | |_ ");
            Console.WriteLine("  / /\\ / | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\   / _\\ | |/ _` | '_ \\| __|");
            Console.WriteLine(" / /_//| |_| | | | | (_| |  __/ (_) | | | | / /   | | (_| | | | | |_ ");
            Console.WriteLine("/___,'  \\__,_|_| |_|\\__, |\\___|\\___/|_| |_| \\/    |_|\\__, |_| |_|\\__|");
            Console.WriteLine("                    |___/                            |___/           ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" ********************************************************************************");
            Console.WriteLine("*                    /   \\              /'\\       _                              *");
            Console.WriteLine("*\\_..           /'.,/     \\_         .,'   \\     / \\_                            *");
            Console.WriteLine("*    \\         /            \\      _/       \\_  /    \\     _                     *");
            Console.WriteLine("*     \\__,.   /              \\    /           \\/.,   _|  _/ \\                    *");
            Console.WriteLine("*          \\_/                \\  /',.,''\\      \\_ \\_/  \\/    \\                   *");
            Console.WriteLine("*                           _  \\/   /    ',../',.\\    _/      \\                  *");
            Console.WriteLine("*             /           _/m\\  \\  /    |         \\  /.,/'\\   _\\                 *");
            Console.WriteLine("*           _/           /MMmm\\  \\_     |          \\/      \\_/  \\                *");
            Console.WriteLine("*          /      \\     |MMMMmm|   \\__   \\          \\_       \\   \\_              *");
            Console.WriteLine("*                  \\   /MMMMMMm|      \\   \\           \\       \\    \\             *");
            Console.WriteLine("*                   \\  |MMMMMMmm\\      \\___            \\_      \\_   \\            *");
            Console.WriteLine("*                    \\|MMMMMMMMmm|____.'  /\\_            \\       \\   \\_          *");
            Console.WriteLine("*                    /'.,___________...,,'   \\            \\   \\        \\         *");
            Console.WriteLine("*                   /       \\          |      \\    |__     \\   \\_       \\        *");
            Console.WriteLine("*                 _/        |           \\      \\_     \\     \\    \\       \\_      *");
            Console.WriteLine("*                /                               \\     \\     \\_   \\        \\     *");
            Console.WriteLine("*                                                 \\     \\      \\   \\__      \\    *");
            Console.WriteLine(" ********************************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Cave()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("                  ______________");
            Console.WriteLine("             ____/##############\\____");
            Console.WriteLine("         ___/########################\\___");
            Console.WriteLine("       _/################################\\_");
            Console.WriteLine("      /####################################\\");
            Console.WriteLine("     /######################################\\");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.WriteLine("    |########################################|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_\\|/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|#############################");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\\|/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("########|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("__\\|/_");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("You are about to go further into the dungeon.. be ready! Press enter to grab your sword and begin the dungeon battle!");
            Console.ReadLine();
        }

        public static void DrawMonster(string Monster)
        {
            Console.Clear();
            if (Monster == "Dragon")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                          ");
                Console.WriteLine("                /\\/\\/\\/\\/\\/\\        ");
                Console.WriteLine("             /\\/MMMMMMMMMMMM>            ");
                Console.WriteLine("         /\\/\\MMMMMMMMMMMMMMMM>          ");
                Console.WriteLine("       <MMMMMMMMMMMMMMMMMMMMMM            ");
                Console.WriteLine("      <MMMMMMMMMMMMMMMMMMMMMMMMM.         ");
                Console.Write("     <MMMMMMMMMMMMMMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("/\\");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MMM:       ");
                Console.Write("    <MMMMMMMMMMMMMMMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\\ \\");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MMM      ");
                Console.Write("   <MMMMMMMMMMMMMMMMMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\\/");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MMMM.     ");

                Console.WriteLine("  <MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM, A  ");
                Console.WriteLine("  <MMMMMMMMMMMMMMMMMMMMMMMM:$MMMMMMMMMMM. ");
                Console.WriteLine("  <MMMMMMMMMMMMMMMMMMMMMMM.  MMMMMMMMMMM. ");
                Console.Write("   <MMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("M   MMM      MMMMMMM   ");
                Console.Write("   <MMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("M    MMM     MMMMM.     ");
                Console.Write("   <MMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("M     MM               ");
                Console.Write("   <MMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("M.                    ");
                Console.Write("   <MMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MM.                 ");
                Console.Write("    <MMMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MMM.              ");
                Console.Write("     <MMMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MMM.           ");
                Console.Write("      <MMMMMMMMMM");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("VVVVVVVVVVV");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MMMM.         ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Monster == "Slime")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("                                          ");
                Console.WriteLine("             ________________________");
                Console.WriteLine("         ___/########################\\___");
                Console.WriteLine("       _/################################\\_");
                Console.WriteLine("      /####################################\\");
                Console.WriteLine("     /######################################\\");
                Console.WriteLine("    |########/  \\################/  \\########|");
                Console.WriteLine("    |########\\  /################\\  /########|");
                Console.WriteLine("    |########################################|");
                Console.WriteLine("   /##############vvvvvvvvvvvvvv##############\\");
                Console.WriteLine("  /###############^^^^^^^^^^^^^^###############\\");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Monster == "Ogre")
            {
                Console.WriteLine("");
                Console.WriteLine("              __,='`````'=/__");
                Console.WriteLine("             '//  (o) \\(o) \\           _,-,");
                Console.WriteLine("             //|     ,_)    |       ,-'`_,-\\");
                Console.WriteLine("           ,-~~~\\  `'==='  /-,      \\==```` \\__");
                Console.WriteLine("          /        `----'     `\\     \\       \\/");
                Console.WriteLine("       ,-`                  ,   \\  ,.-\\       \\");
                Console.WriteLine("      /      ,               \\,-`\\`_,-`\\_,..--'\\");
                Console.WriteLine("     ,`    ,/,              ,>,   )     \\--`````\\");
                Console.WriteLine("     (      `\\`---'`  `-,-'`_,<   \\      \\_,.--'`");
                Console.WriteLine("      `.      `--. _,-'`_,-`  |    \\");
                Console.WriteLine("       [`-.___   <`_,-'`------(    /");
                Console.WriteLine("       (`` _,-\\   \\ --`````````|--`");
                Console.WriteLine("        >-`_,-`\\,-` ,          |");
                Console.WriteLine("      <`_,'     ,  /\\          /");
                Console.WriteLine("       `  \\/\\,-/ `/  \\/`\\_/V\\_/");
                Console.WriteLine("          (  ._. )    ( .__. )");
                Console.WriteLine("          |      |    |      |");
                Console.WriteLine("           \\,---_|    |_---./");
                Console.WriteLine("           ooOO(_)    (_)OOoo");
            }
            else
            {
                Console.WriteLine("Invalid Monster");
            }
            Console.WriteLine("");
        }

        public static void Hit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("  ,.                 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("__  __     __     ______ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("  \\%`.              ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("/\\ \\_\\ \\   /\\ \\   /\\__  _\\ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("   `.%`.            ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\\ \\  __ \\  \\ \\ \\  \\/_/\\ \\/ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("     `.%`.           ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\\ \\_\\ \\_\\  \\ \\_\\    \\ \\_\\ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("       `.%`.          ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\\/_/\\/_/   \\/_/     \\/_/");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("         `.%`.");
            Console.WriteLine("           `.%`.    __");
            Console.WriteLine("             `.%`.  \\ \\");
            Console.WriteLine("               `.%`./_/");
            Console.WriteLine("                 `./ /.");
            Console.WriteLine("                __/\\/:/;.");
            Console.WriteLine("                \\__/  `:/;.");
            Console.WriteLine("                        `:/;.,    ");
            Console.WriteLine("                          `:/ ;");
            Console.WriteLine("                            `'");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You hit! Press Enter to continue...");
            Console.ReadLine();
        }

        public static void Ouch(string Monster)
        {
            Console.Clear();
            if (Monster == "Dragon")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("        )                       )  ");
                Console.WriteLine("     ( /(              (     ( /(  ");
                Console.WriteLine("     )\\())      (      )\\    )\\()) ");
                Console.WriteLine("    ((_)\\       )\\   (((_)  ((_)\\  ");
                Console.WriteLine("      ((_)   _ ((_)  )\\___   _((_) ");
                Console.WriteLine("     / _ \\  | | | | ((/ __| | || | ");
                Console.WriteLine("    | (_) | | |_| |  | (__  | __ | ");
                Console.WriteLine("     \\___/   \\___/    \\___| |_||_| ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("           (  .      )");
                Console.WriteLine("       )           (              )");
                Console.WriteLine("             .  '   .   '  .  '  .");
                Console.WriteLine("    (    , )       (.   )  (   ',    )");
                Console.WriteLine("     .' ) ( . )    ,  ( ,     )   ( .");
                Console.WriteLine("  ). , ( .   (  ) ( , ')  .' (  ,    )");
                Console.WriteLine(" (_,) . ), ) _) _,')  (, ) '. )  ,. (' )");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The Dragon burned you! Press Enter to continue...");
            }
            else if (Monster == "Slime")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   .---.  .-. .-.  ,--,  .-. .-. ");
                Console.WriteLine("  / .-. ) | | | |.' .')  | | | | ");
                Console.WriteLine("  | | |(_)| | | ||  |(_) | `-' | ");
                Console.WriteLine("  | | | | | | | |\\  \\    | .-. | ");
                Console.WriteLine("  \\ `-' / | `-')| \\  `-. | | |)| ");
                Console.WriteLine("   )---'  `---(_)  \\____\\/(  (_) ");
                Console.WriteLine("  (_)                   (__)  ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("_      _      _      _      _      _   ");
                Console.WriteLine(")`'-.,_)`'-.,_)`'-.,_)`'-.,_)`'-.,_)`'-.");
                Console.WriteLine("_     _     _     _     _     _     _    ");
                Console.WriteLine(")`'-.,)`'-.,)`'-.,)`'-.,)`'-.,)`'-.,)`'-.");
                Console.WriteLine("_    _    _    _    _    _    _    _    _");
                Console.WriteLine(")'-.,)'-.,)'-.,)'-.,)'-.,)'-.,)'-.,)'-.,)'-.,");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You got slimed by the Slime! Press Enter to continue...");
            }
            else if (Monster == "Ogre")
            {
                Console.WriteLine("   _______           _______          ");
                Console.WriteLine("  (  ___  )|\\     /|(  ____ \\|\\     /|");
                Console.WriteLine("  | (   ) || )   ( || (    \\/| )   ( |");
                Console.WriteLine("  | |   | || |   | || |      | (___) |");
                Console.WriteLine("  | |   | || |   | || |      |  ___  |");
                Console.WriteLine("  | |   | || |   | || |      | (   ) |");
                Console.WriteLine("  | (___) || (___) || (____/\\| )   ( |");
                Console.WriteLine("  (_______)(_______)(_______/|/     \\|");
                Console.WriteLine("\\ \\ \\ \\ \\ \\ \\ | | | | | | / / / / / / / /");
                Console.WriteLine("");
                Console.WriteLine("The Ogre hit you with his hammer! Press Enter to continue...");
            }
            else
            {
                Console.WriteLine("Invalid Monster");
            }
            Console.ReadLine();
        }
        
        public static void Defeat()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("__   __            _                    ");
            Console.WriteLine("\\ \\ / /           | |                   ");
            Console.WriteLine(" \\ V /___  _   _  | |     ___  ___  ___ ");
            Console.WriteLine("  \\ // _ \\| | | | | |    / _ \\/ __|/ _ \\");
            Console.WriteLine("  | | (_) | |_| | | |___| (_) \\__ \\  __/");
            Console.WriteLine("  \\_/\\___/ \\__,_| \\_____/\\___/|___/\\___|");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You were defeated and monsters roamed across the lands!");
        }

        public static void Victory()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  _   _ _____ _____ _____ _____________   ___ ");
            Console.WriteLine(" | | | |_   _/  __ \\_   _|  _  | ___ \\ \\ / / |");
            Console.WriteLine(" | | | | | | | /  \\/ | | | | | | |_/ /\\ V /| |");
            Console.WriteLine(" | | | | | | | |     | | | | | |    /  \\ / | |");
            Console.WriteLine(" \\ \\_/ /_| |_| \\__/\\ | | \\ \\_/ / |\\ \\  | | |_|");
            Console.WriteLine("  \\___/ \\___/ \\____/ \\_/  \\___/\\_| \\_| \\_/ (_)");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You defeated the monsters and saved the lands!");
        }

    }
}
