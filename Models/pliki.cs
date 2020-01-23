using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class pliki
    {
        [Key]
        public int id_pliki { get; set; }
        public string nazwa { get; set; }
        public int id_uzytkownicy { get; set; }
        public uzytkownicy uzytkownicy { get; set; }
        public string link_bezpośredni { get; set; }
    }
}
