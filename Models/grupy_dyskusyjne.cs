using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class grupy_dyskusyjne
    {
        [Key]
        public int id_grupy_dyskusyjne { get; set; }
        public string nazwa { get; set; }
        public int id_uzytkownicy { get; set; }
        public uzytkownicy uzytkownicy { get; set; }
        public int data_zalozenia { get; set; }

        public ICollection<zaproszenia_do_grup> zaproszenia_Do_Grups { get; set; }
        public ICollection<czlonkowie_grup> czlonkowie_Grups { get; set; }
    }
}
