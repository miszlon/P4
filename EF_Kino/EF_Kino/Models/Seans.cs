using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Seans
    {
        public int IdSeansu { get; set; }
        public string NazwaFIlmu { get; set; }
        public DateTime Data_i_Godz_Rozpoczecia { get; set; }
        public virtual ICollection<Bilet> Bilet { get; set; }


    }
}
