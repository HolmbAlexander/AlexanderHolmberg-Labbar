using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class Movie
    {
        public enum GenreType
        {
            Romantic = 1,
            Action,
            Thriller,
            Children,
            Comedy,
            War,
            Drama
        }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
    }
}
