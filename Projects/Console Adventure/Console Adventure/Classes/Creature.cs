using Console_Adventure.DataStores.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure.Classes
{
    class Creature : INonPlayerCharacters
    {
        public string Actions { get; set; }
        public string Interactions { get; set; }
        public string Sound { get; set; }
        public string Looks { get; set; }
        public int Number { get; set; }
        public string Specie { get; set; }

        public string Action()
        {
            return Actions;
        }

        public string Speak()
        {
            return " You stands still and listen to what you can hear in the room...\n" + Sound;
        }

        public string ObservCharacter()
        {
            return "You see " + Number + " " + Specie + ". " + Looks + ".";
        }

        public string Interaction()
        {
            return Interactions;
        }
    }
}
