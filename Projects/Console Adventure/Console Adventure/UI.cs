using Console_Adventure.Classes;
using Console_Adventure.DataStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console_Adventure
{
    class UI
    {
        #region Variables
        int mirrorQuest = 0;
        int RoomInteractionInt;
        int RoomChoosenInt;
        int RoomCreatureInt;
        bool gameLoop = true;
        bool loopActions = true;
        bool interactionLoop = true;
        Lists lists = new Lists();
        Graphics graphics = new Graphics();
        #endregion

        public void RoomChoosen()
        {
            while (gameLoop)
            {
                interactionLoop = true;
                loopActions = true;
                gameLoop = true;

                MainRoomMenu();
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D0:
                        gameLoop = false;
                        break;

                    case ConsoleKey.D1:
                        RoomChoosenInt = 1;
                        RoomCreatureInt = 1;
                        RoomInteractionInt = 1;
                        Actions();
                        break;

                    case ConsoleKey.D2:
                        RoomChoosenInt = 2;
                        RoomCreatureInt = 6;
                        RoomInteractionInt = 6;
                        Actions();
                        break; 

                    case ConsoleKey.D3:
                        RoomChoosenInt = 3;
                        RoomCreatureInt = 4;
                        RoomInteractionInt = 4;
                        Actions();
                        break;

                    case ConsoleKey.D4:
                        RoomChoosenInt = 4;
                        Room4();
                        break;

                    case ConsoleKey.D5:
                        RoomChoosenInt = 5;
                        RoomCreatureInt = 2;
                        RoomInteractionInt = 2;
                        Actions();
                        break;

                    case ConsoleKey.D6:
                        ExitQuest();
                        break;

                    case ConsoleKey.D7:
                        RoomChoosenInt = 7;
                        RoomCreatureInt = 5;
                        RoomInteractionInt = 5;
                        Actions();
                        break;

                    case ConsoleKey.D8:
                        RoomChoosenInt = 8;
                        RoomCreatureInt = 7;
                        RoomInteractionInt = 7;
                        Actions();
                        break;

                    case ConsoleKey.D9:
                        CheckNotebook();
                        break;
                }

            }
        }

        #region Menus
        public void MainRoomMenu()
        {
            Console.Clear();
            Console.WriteLine("You hear a distant voice saying: Choose a door to find your doom! *OooUUoUOuoOUUOoo*");
            Console.WriteLine("You see eight doors around you when you look around.");
            Console.WriteLine("1: Big oak door with the number 1 on it.");
            Console.WriteLine("2: Small hatch with the number 2 on it.");
            Console.WriteLine("3: Metal door with the number 3 on it.");
            Console.WriteLine("4: Big metal door wich seems to be extremly hot, cant see any number because of the heatwaves.");
            Console.WriteLine("5: Wooden door with the number 5 on it.");
            Console.WriteLine("6: Golden door with an sign on it.");
            Console.WriteLine("7: Green wooden door wit the number 7 on it.");
            Console.WriteLine("8: Glass door with the number 8 painted with a red color on it.");
            Console.WriteLine();
            Console.WriteLine("9: Check notebook.");
            Console.WriteLine("0: Exit to main menu.");
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Alexanders Labb6 survival game!");
            Console.WriteLine("Point of the game is to find clues to escape your oncoming death.");
            Console.WriteLine();
            Console.WriteLine("1: Play game");
            Console.WriteLine("2: Story");
            Console.WriteLine("3: Quit");
        }

        public void StoryMenu()
        {
            Console.Clear();
            Console.WriteLine("You are a poor farmer that grew tired of barely scraping by each month.");
            Console.WriteLine("With a hurting belly you decide to break in to the old tower in the forest.");
            Console.WriteLine("You look around at the bottom and see a window att the top of the tower.");
            Console.WriteLine("After a long climb you drop down from the window into a circular room filled with doors.");
            Console.WriteLine("You hear a distant laugh... You start to think you shouldn't have come here... ");
            Console.WriteLine("You realise the window is out of your reach... You need to find a way to escape...");
            Console.ReadKey(true);
        }
        #endregion

        #region Quests
        public void MirrorQuest()
        {
            if (mirrorQuest == 0)
            {
                mirrorQuest++;
                Console.WriteLine("You dont belong here mortal...");
                Console.WriteLine("If you cant answer my 3 questions you wont leave this room alive...");
                Console.WriteLine("But if you can answer my questions... I will give you a piece of the puzzel to get out.");
                Console.ReadKey(true);
                Console.WriteLine("How many sides does a qube have?");
                Console.WriteLine("1: 4.");
                Console.WriteLine("2: 6.");
                Console.WriteLine("3: 8.");
                var answer1 = Console.ReadKey(true).Key;
                if (answer1 == ConsoleKey.D2)
                {
                    Console.WriteLine("Good...");
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.WriteLine("What are Scotland's national animal?");
                    Console.WriteLine("1: Swan");
                    Console.WriteLine("2: Deer");
                    Console.WriteLine("3: Unicorn");
                    var answer2 = Console.ReadKey(true).Key;
                    if (answer2 == ConsoleKey.D3)
                    {
                        Console.WriteLine("are you a brony!?!...");
                        Console.ReadKey(true);
                        Console.Clear();
                        Console.WriteLine("Last question... What does the fox say?");
                        Console.WriteLine("1: Jipp jipp jipp");
                        Console.WriteLine("2: Wupp wupp wupp");
                        Console.WriteLine("3: Shi shi shiiii");
                        Console.ReadKey(true);
                        Console.WriteLine("Well i dont fucking know... Might be right...");
                        Console.ReadKey(true);
                        Console.Clear();
                        Console.WriteLine("As i promised. A clue...");
                        Console.WriteLine("*CAM-*");
                        Console.WriteLine("Now leave before i change my mind...");
                    }
                    else
                        Death();
                }
                else
                    Death();
            }
            else
                if (mirrorQuest > 0)
            {
                Console.WriteLine("Just leave... I dont have anymore clues for you...");
                Console.ReadKey(true);
            }
                
        }

        public void ExitQuest()
        {
            Console.Clear();
            Console.WriteLine("As you walk up to the door you see a small light threw a hatch in the door.");
            Console.WriteLine("You knock on the door and a voice from the other side says: Password?");
            var inputExit = Console.ReadLine().ToUpper();
            if (inputExit == "CAMELHUMP")
            {
                RoomChoosenInt = 6;
                RoomCreatureInt = 3;
                RoomInteractionInt = 3;
                bool isExitLoop = true;
                while (isExitLoop)
                {
                    interactionLoop = true;
                    Console.Clear();
                    Console.WriteLine("1: Look around the room.");
                    Console.WriteLine("2: Inspect creature in room.");
                    Console.WriteLine("3: Interact with creature.");
                    Console.WriteLine("4: Leave the room.");
                    Console.WriteLine("5: Leave this awfull tower.");
                    var isExitAction = Console.ReadKey(true).Key;
                    switch (isExitAction)
                    {
                        case ConsoleKey.D1:
                            InspectRoom();
                            break;

                        case ConsoleKey.D2:
                            InspectHuman();
                            break;


                        case ConsoleKey.D3:
                            Interaction();
                            break;

                        case ConsoleKey.D4:
                            isExitLoop = false;
                            loopActions = false;
                            break;
                        case ConsoleKey.D5:
                            Console.Clear();
                            Console.WriteLine("You escape the tower with your all your limbs and as poor as you were when you went in. But atleast you can live to tell the tale...");
                            Console.ReadKey(true);
                            graphics.WinGraphics();
                            var close = Console.ReadKey(true);
                            gameLoop = false;
                            loopActions = false;
                            isExitLoop = false;
                            interactionLoop = false;
                            break;
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Oi, thats not the right password...");
                Console.WriteLine("Cant let ya out with that mate... Sorry...");
                Console.WriteLine("Try finding clues in the other rooms. But beware of the crazy gal with the knife!");
                Console.ReadKey(true);
            }
        }
        #endregion

        public void CheckNotebook()
        {
            Console.Clear();
            Console.WriteLine(lists.rooms[8].Notebook());
            var close = Console.ReadKey(true);
        }

        public void AddNotebook()
        {
            if (RoomCreatureInt == 6)
            {
                lists.rooms[8].Note1 = "-ELH-";
            }
            else if (RoomCreatureInt == 5)
            {
                lists.rooms[8].Note2 = "-UMP";
            }
            else if (RoomCreatureInt == 7)
            {
                lists.rooms[8].Note3 = "CAM-";
            }
        }

        public void Room4()
        {
            Console.Clear();
            Console.WriteLine("It gets hard to get close because of the rising temperature. Do you still wish to open the glowing door?");
            Console.WriteLine("1: Yes.");
            Console.WriteLine("2: No.");
            var inputRoom4 = Console.ReadKey(true).Key;
            if (inputRoom4 == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine(lists.rooms[3].ObservEnviorment());
                Console.ReadKey(true);
                Death();
            }
        }

        public void Death()
        {
            Console.Clear();
            graphics.DeathGraphic();
            Console.WriteLine("You should be more cautious... You died...");
            Console.ReadKey(true);
            Console.Clear();
            graphics.StartGraphic();
            gameLoop = false;
            loopActions = false;
            interactionLoop = false;
        }

        #region Inspect methods
        public void InspectRoom()
        {
            Console.Clear();
            Console.WriteLine(lists.rooms[RoomChoosenInt - 1].ObservEnviorment());
            Console.ReadKey(true);
            
        }

        public void InspectCreature()
        {
            Console.Clear();
            Console.WriteLine(lists.creatures[RoomCreatureInt - 4].ObservCharacter());
            Console.WriteLine(lists.creatures[RoomCreatureInt - 4].Speak());
            Console.ReadKey(true);
        }

        public void InspectHuman()
        {
            Console.Clear();
            Console.WriteLine(lists.humans[RoomCreatureInt - 1].ObservCharacter());
            Console.WriteLine(lists.humans[RoomCreatureInt - 1].Speak());
            Console.ReadKey(true);
        }
        #endregion

        #region Interactions
        public void Actions()
        {
            while (loopActions)
            {
                interactionLoop = true;
                Console.Clear();
                Console.WriteLine("1: Look around the room.");
                Console.WriteLine("2: Inspect creature in room.");
                Console.WriteLine("3: Interact with creature.");
                Console.WriteLine("4: Leave the room.");
                var inputAction = Console.ReadKey(true).Key;
                switch (inputAction)
                {
                    case ConsoleKey.D1:
                        InspectRoom();
                        break;

                    case ConsoleKey.D2:
                        if (RoomCreatureInt <= 3)
                        {
                            InspectHuman();
                        }
                        else
                        {
                            InspectCreature();
                        }
                        break;

                    case ConsoleKey.D3:
                        Interaction();
                        break;

                    case ConsoleKey.D4:
                        loopActions = false;
                        break;
                }
            }
        }

        public void Interaction()
        {
            while (interactionLoop)
            {

                Console.Clear();
                if (RoomCreatureInt <= 3)
                {
                    Console.WriteLine(lists.humans[RoomCreatureInt - 1].Interaction());
                }
                else
                {
                    Console.WriteLine(lists.creatures[RoomCreatureInt - 4].Interaction());
                }
                Console.WriteLine("1: Interact.");
                Console.WriteLine("2: Back away.");
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        AddNotebook();
                        InteractionCreature();
                        break;

                    case ConsoleKey.D2:
                        interactionLoop = false;
                        break;
                }
            }
        }

        public void InteractionCreature()
        {
            Console.Clear();
            switch (RoomCreatureInt)
            {
                case 1:
                    Console.WriteLine(lists.humans[0].Action());
                    Console.ReadKey(true);
                    Death();
                    break;

                case 2:
                    Console.WriteLine(lists.humans[RoomCreatureInt - 1].Action());
                    Console.ReadKey(true);
                    break;

                case 3:
                    Console.WriteLine(lists.humans[RoomCreatureInt - 1].Action());
                    Console.ReadKey(true);
                    break;

                case 4:
                    Console.WriteLine(lists.creatures[0].Action());
                    Console.ReadKey(true);
                    Death();
                    break;

                case 7:
                    Console.WriteLine(lists.creatures[RoomCreatureInt - 4].Action());
                    Console.ReadKey(true);
                    MirrorQuest();
                    break;

                default:
                        Console.WriteLine(lists.creatures[RoomCreatureInt - 4].Action());
                        Console.ReadKey(true);
                        break;
            }
        }
        #endregion
    }
}