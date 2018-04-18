using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMovies
{
    /*
        PK ID int
        Title string
        YearReleased int
        Genre string
        Tagline string
        Rating decimal
        */
    class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
        public string Tagline { get; set; }
        public decimal Rating { get; set; }
    }
}
