using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class znajomi
    {
        [Key]
        public int Id_znajomi { get; set; }
        public int Id_uzytkownicy { get; set; }
        public uzytkownicy uzytkownicy {get; set;}
        public int Id_znajomwgo { get; set; }
        public int poczatek_znajomosci { get; set; }
    }
}
