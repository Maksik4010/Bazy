using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication16.Models
{
    public class uzytkownicy
    {
        [Key]
        public int Id_uzytkownicy{ get; set; }
        public string login { get; set; }
        public string haslo { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string ksywka { get; set; }
        public int data_zalozenia { get; set; }
        public int ostatnie_logowanie { get; set; }
        public int ip_ostatniego_logowania {get;set;}
        public string kraj { get; set; }
        public int liczba_znajomych { get; set; }

        public ICollection<znajomi> Znajomis { get; set; }
        public ICollection<zdjecia> Zdjecias { get; set; }
        public ICollection<zaproszenia_do_znajomych> zaproszenia_Do_Znajomyches { get; set; }
        public ICollection<zainteresowania> zainteresowanias { get; set; }
        public ICollection<wiadomosci> wiadomoscis { get; set; }
        public ICollection<posty> posties { get; set; }
        public ICollection<pliki> plikis { get; set; }
        public ICollection<komentarze> komentarzes { get; set; }
        public ICollection<grupy_dyskusyjne> grupy_Dyskusyjnes { get; set; }
        public ICollection<filmy> filmies { get; set; }
        public ICollection<fanpage> fanpages { get; set; }
        public ICollection<reakcja_na_posty> reakcja_Na_Posties { get; set; }
    }


}
