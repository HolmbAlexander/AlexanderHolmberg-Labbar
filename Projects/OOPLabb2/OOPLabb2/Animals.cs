using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPLabb2
{
    public abstract class Animals
    {
        public string Name { get; set; }
        public int LifeSpan { get; set; }
        public string Movement { get; set; }
        public string Food { get; set; }

        public virtual string BasicInfo()
        {
            return String.Format("Name: {0}, Lifespan: {1}, Movement: {2}, Eats: {3},",
                                 Name,
                                 LifeSpan,
                                 Movement,
                                 Food);
        }
    }
}