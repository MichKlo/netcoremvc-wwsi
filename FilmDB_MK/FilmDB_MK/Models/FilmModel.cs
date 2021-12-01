using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDB_MK.Models
{
    public class FilmModel
    {
        public static object AddFilm { get; internal set; }
        public int ID { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

    }
}
