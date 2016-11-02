using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Adventure.DataStores.IRepositories
{
    interface INonPlayerCharacters
    {
        string Speak();
        string ObservCharacter();
        string Interaction();
        string Action();
    }
}
