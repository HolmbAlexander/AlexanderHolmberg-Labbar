using Console_Adventure.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure.DataStores
{
    class Lists
    {
        public List<Creature> creatures = new List<Creature>
        {
            new Creature { Number = 2,  Specie = "hell hounds",   Looks = "They are huge and have eyes dark as a nightsky. You fear that they might be hostile.",
                Sound = "Woof woof! Gnarl... Grrr...",      Interactions = "They goes bezerk and tries break out of there chains to launch at you...",
                Actions = "They tear you to pieces..."},

            new Creature { Number = 1,  Specie = "slug",   Looks = "IT´S HUGE! You stare for it a long time and realise it moves towards you in a slow pace",
                Sound = "Squisch... Squisch... Squisch...", Interactions = "You can easily walk around it if you like...",
                Actions = "You walk around it to find a note. You read it and it says: *-UMP*... "},

            new Creature { Number = 18, Specie = "rats",   Looks = "You see a pile of rats ontop of a rotting corpse. They stop eating the corpse when they notice you.",
                Sound = "Screeh... *munch* Screeh...",      Interactions = "You belive they are hostile but what can a bunch of rats really do to a full grown man?...",
                Actions = "The rats attacks you but you squish them easily with your boots. You search the rotten corspe and find a note. It says: *-ELH-*... "},

            new Creature { Number = 1,  Specie = "mirror", Looks = "All you can see in the mirror is darkness, even when you from afar tries to get a glimpse of yourself you can only see darkness.",
                Sound = "*You hear the glass cracking beneth your feet*", Interactions = "Come forth boy....",
                Actions = "Suddenly a white face appers in the mirror and you feel a cold sensation in your feet. You realise you are frozen still."}
        };

        public List<Human> humans = new List<Human>
        {
            new Human { Sex = "woman",  Looks = "robe dripping of dark blood and a sacrifical knife in her hand.",  Age = 25,
                Conversation = "*Whispers* Regna terrae, cantate Deo, psallite Domino per caelum, caelum antiquos... *Whispers*", Interactions = "She looks up on you slowly and grips the knife hard with her right hand...",
                Actions = "You approach the woman slowly. She jumps at you and shoves the knife in your left eye... The last thing you see before it all goes dark is the women licking the knife clean..."},

            new Human { Sex = "man",    Looks = "dark robe and a schyte in his hands.",                             Age = 80,
                Conversation = "Come closer traveler...", Interactions = "I dont remember inviting you to my tower. I wont let you stay here... But i wont kill you myself.\nI have allot of minions in my tower and they will do that for my if you cant escape on your own... If you wish to leave with your life intact you need to exit threw the golden door...\nBut i wont give you the secret word... *MUHAHAHAHAH*",
                Actions = "I wont tell you the password... Now go die somewhere so i can ressurect you as one of my undead minions... "},

            new Human { Sex = "man", Looks = "shiny armor.", Age = 30, Conversation = "Oi mate! You focking made it out... Run then you foiking bastard! Run for all ya hold dear!...", Interactions = "The knight looks like hes seeing the biggest fucking idiot ever...",
                Actions = "Are you fooking deaf mate?!? I said run... I can't leave because the old bastard cursed me. I prob have to kill ya if you dont run soon... GO on lad, RUN!"}
        };

        public List<Room> rooms = new List<Room>
        {
            new Room { Size = "big",    Enviroment = "In the room there is a stoneshrine with a head of a goat ontop of it. Burning candles are placed around the decapitated head and a figure bows next to the table." },
            new Room { Size = "small",  Enviroment = "In the room there is a pile of rats ontop of something" },
            new Room { Size = "big",    Enviroment = "You see a treasure chest guarded by two big creatures." },
            new Room { Size = "big",    Enviroment = "Even when you burn your hands opening the door, you still force it open. Flames engulfs you and turns you into a crispy corpse..." },
            new Room { Size = "small",  Enviroment = "There is a small table with a burning candel on it, an old man stands next to it." },
            new Room { Size = "big",    Enviroment = "You find a staircase leading down. You runs as fast as you can down the stairs and exits the tower, you are finally free from that madmans deathtrap. Do you wish to leave?" },
            new Room { Size = "small",  Enviroment = "You see a big green creature that stands still. It looks like there is a table behind it."},
            new Room { Size = "big",    Enviroment = "Everything is made out of glass and darkness as far ass you can see. You see a mirror at the back of the room." },
            new Room { Note1 = "", Note2 = "", Note3 = "" },
        };
    }
}
