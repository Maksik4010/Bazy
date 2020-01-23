using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class zdjecia
    {
        [Key]
        public int Id_zjecia { get; set; }
        public string nazwa { get; set; }
        public int Id_użytkownicy { get; set; }
        public uzytkownicy uzytkownicy { get; set; }
        public string link_bezposredni { get; set; }
    }
}
