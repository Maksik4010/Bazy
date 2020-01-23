using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class posty
    {
        [Key]
        public int id_posty { get; set; }
        public int typ { get; set; }
        public int id_zuytkownicy { get; set; }
        public uzytkownicy uzytkownicy { get; set; }
        public string tresc { get; set; }
        public int data_utworzenia { get; set; }
        public int liczba_like { get; set; }
        public int liczba_dislike { get; set; }
        public int status_komentarzy { get; set; }

        public ICollection<komentarze> komentarzes { get; set; }
    }
}
