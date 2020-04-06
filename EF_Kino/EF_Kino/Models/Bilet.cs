using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Bilet
    {
        public int IdBiletu { get; set; }
        public int Cena { get; set; }
        public virtual Seans Seans { get; set; }
        public virtual Miejsce Miejsce { get; set; }

    }
}
