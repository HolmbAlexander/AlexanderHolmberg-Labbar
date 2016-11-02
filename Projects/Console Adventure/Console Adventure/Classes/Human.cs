using Console_Adventure.DataStores.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure.Classes
{
    class Human : INonPlayerCharacters
    {
        public string Actions { get; set; }
        public string Interactions { get; set; }
        public string Conversation { get; set; }
        public int Age { get; set; }
        public string Looks { get; set; }
        public string Sex { get; set; }

        public string Action()
        {
            return Actions;
        }

        public string Speak()
        {
            return " You stands still and listen to what you can hear in the room...\n" + Conversation;
        }

        public string ObservCharacter()
        {
            return "You see a " + Sex + " dressed in " + Looks + " Looks to be around " + Age +".";
        }

        public string Interaction()
        {
            return Interactions;
        }
    }
}
