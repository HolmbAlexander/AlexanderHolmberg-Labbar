using Console_Adventure.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure
{
    class Runtime
    {
        Graphics graphics = new Graphics();
        public void Start()
        {
            Console.Clear();
            graphics.StartGraphic();
            var loop = true;
            while (loop)
            {
                UI ui = new UI();
                ui.MainMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        ui.RoomChoosen();
                        break;

                    case ConsoleKey.D2:
                        ui.StoryMenu();
                        break;

                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
