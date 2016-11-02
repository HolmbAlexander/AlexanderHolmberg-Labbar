using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure.Classes
{
    class Graphics
    {
        public void DeathGraphic()
        {
            Console.WriteLine(@"███████████████████████████");
            Console.WriteLine(@"███████▀▀▀░░░░░░░▀▀▀███████");
            Console.WriteLine(@"████▀░░░░░░░░░░░░░░░░░▀████");
            Console.WriteLine(@"███│░░░░░░░░░░░░░░░░░░░│███");
            Console.WriteLine(@"██▌│░░░░░░░░░░░░░░░░░░░│▐██");
            Console.WriteLine(@"██░└┐░░░░░░░░░░░░░░░░░┌┘░██");
            Console.WriteLine(@"██░░└┐░░░░░░░░░░░░░░░┌┘░░██");
            Console.WriteLine(@"██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██");
            Console.WriteLine(@"██▌░│██████▌░░░▐██████│░▐██");
            Console.WriteLine(@"███░│▐███▀▀░░▄░░▀▀███▌│░███");
            Console.WriteLine(@"██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██");
            Console.WriteLine(@"██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██");
            Console.WriteLine(@"████▄─┘██▌░░░░░░░▐██└─▄████");
            Console.WriteLine(@"█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████");
            Console.WriteLine(@"████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████");
            Console.WriteLine(@"█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████");
            Console.WriteLine(@"███████▄░░░░░░░░░░░▄███████");
            Console.WriteLine(@"██████████▄▄▄▄▄▄▄██████████");
            Console.WriteLine(@"███████████████████████████");
        }

        public void StartGraphic()
        {
            Console.WriteLine(@" ██████╗██╗   ██╗██████╗ ███████╗███████╗     ██████╗ ███████╗    ████████╗██╗  ██╗███████╗         ");
            Console.WriteLine(@"██╔════╝██║   ██║██╔══██╗██╔════╝██╔════╝    ██╔═══██╗██╔════╝    ╚══██╔══╝██║  ██║██╔════╝         ");
            Console.WriteLine(@"██║     ██║   ██║██████╔╝███████╗█████╗      ██║   ██║█████╗         ██║   ███████║█████╗           ");
            Console.WriteLine(@"██║     ██║   ██║██╔══██╗╚════██║██╔══╝      ██║   ██║██╔══╝         ██║   ██╔══██║██╔══╝           ");
            Console.WriteLine(@"╚██████╗╚██████╔╝██║  ██║███████║███████╗    ╚██████╔╝██║            ██║   ██║  ██║███████╗         ");
            Console.WriteLine(@" ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝     ╚═════╝ ╚═╝            ╚═╝   ╚═╝  ╚═╝╚══════╝         ");
            Console.WriteLine(@"                                                                                                    ");
            Console.WriteLine(@"███╗   ██╗███████╗ ██████╗██████╗  ██████╗ ███╗   ███╗ █████╗ ███╗   ██╗ ██████╗███████╗██████╗     ");
            Console.WriteLine(@"████╗  ██║██╔════╝██╔════╝██╔══██╗██╔═══██╗████╗ ████║██╔══██╗████╗  ██║██╔════╝██╔════╝██╔══██╗    ");
            Console.WriteLine(@"██╔██╗ ██║█████╗  ██║     ██████╔╝██║   ██║██╔████╔██║███████║██╔██╗ ██║██║     █████╗  ██████╔╝    ");
            Console.WriteLine(@"██║╚██╗██║██╔══╝  ██║     ██╔══██╗██║   ██║██║╚██╔╝██║██╔══██║██║╚██╗██║██║     ██╔══╝  ██╔══██╗    ");
            Console.WriteLine(@"██║ ╚████║███████╗╚██████╗██║  ██║╚██████╔╝██║ ╚═╝ ██║██║  ██║██║ ╚████║╚██████╗███████╗██║  ██║    ");
            Console.WriteLine(@"╚═╝  ╚═══╝╚══════╝ ╚═════╝╚═╝  ╚═╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝╚══════╝╚═╝  ╚═╝    ");
            Console.WriteLine("");
            Console.WriteLine(@"                                                |>>>");
            Console.WriteLine(@"                                                |");
            Console.WriteLine(@"                                            _  _|_  _");
            Console.WriteLine(@"                                           |;|_|;|_|;|");
            Console.WriteLine(@"                                           \\.    .  /");
            Console.WriteLine(@"                                            \\:  .  /");
            Console.WriteLine(@"                                             ||:   |");
            Console.WriteLine(@"                                             ||:.  |");
            Console.WriteLine(@"                                             ||:  .|");
            Console.WriteLine(@"                                             ||:   |       \,/");
            Console.WriteLine(@"                                             ||: , |            /`\");
            Console.WriteLine(@"                                             ||:   |");
            Console.WriteLine(@"                                             ||: . |");
            Console.WriteLine(@"              __                            _||_   |");
            Console.WriteLine(@"     ____--`~    '--~~__            __ ----~    ~`---,              ___");
            Console.WriteLine(@"-~--~                   ~---__ ,--~'                  ~~----_____-~'   `~----~~");
            var close = Console.ReadKey(true);
        }

        public void WinGraphics()
        {
            Console.WriteLine(@"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine(@"░░░░░░░▄▄▀▀▀▀▀▀▀▀▀▀▄▄█▄░░░░▄░░░░█░░░░░░░");
            Console.WriteLine(@"░░░░░░█▀░░░░░░░░░░░░░▀▀█▄░░░▀░░░░░░░░░▄░");
            Console.WriteLine(@"░░░░▄▀░░░░░░░░░░░░░░░░░▀██░░░▄▀▀▀▄▄░░▀░░");
            Console.WriteLine(@"░░▄█▀▄█▀▀▀▀▄░░░░░░▄▀▀█▄░▀█▄░░█▄░░░▀█░░░░");
            Console.WriteLine(@"░▄█░▄▀░░▄▄▄░█░░░▄▀▄█▄░▀█░░█▄░░▀█░░░░█░░░");
            Console.WriteLine(@"▄█░░█░░░▀▀▀░█░░▄█░▀▀▀░░█░░░█▄░░█░░░░█░░░");
            Console.WriteLine(@"██░░░▀▄░░░▄█▀░░░▀▄▄▄▄▄█▀░░░▀█░░█▄░░░█░░░");
            Console.WriteLine(@"██░░░░░▀▀▀░░░░░░░░░░░░░░░░░░█░▄█░░░░█░░░");
            Console.WriteLine(@"██░░░░░░░░░░░░░░░░░░░░░█░░░░██▀░░░░█▄░░░");
            Console.WriteLine(@"██░░░░░░░░░░░░░░░░░░░░░█░░░░█░░░░░░░▀▀█▄");
            Console.WriteLine(@"██░░░░░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░▄▄██");
            Console.WriteLine(@"░██░░░░░░░░░░░░░░░░░░▄▀░░░░░█░░░░░░░▀▀█▄");
            Console.WriteLine(@"░▀█░░░░░░█░░░░░░░░░▄█▀░░░░░░█░░░░░░░▄▄██");
            Console.WriteLine(@"░▄██▄░░░░░▀▀▀▄▄▄▄▀▀░░░░░░░░░█░░░░░░░▀▀█▄");
            Console.WriteLine(@"░░▀▀▀▀░░░░░░░░░░░░░░░░░░░░░░█▄▄▄▄▄▄▄▄▄██");
            Console.WriteLine(@"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░░░░░░Wooooo, you won!...░░░░░░░░░░░░░");
            Console.WriteLine(@"░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");

        }
    }
}
