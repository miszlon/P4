using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Miejsce
    {
        public int IdMiejsca { get; set; } 
        public int Rzad { get; set; }
        public int Numer { get; set; }
        public virtual ICollection<Bilet> Bilet { get; set; }
        public virtual Sala Sala { get; set; }

    }
}
