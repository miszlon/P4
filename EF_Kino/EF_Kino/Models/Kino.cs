using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Kino
    {
        public int IdKina { get; set; }
        public string Nazwa { get; set; }
        public ICollection<Sala> Sala { get; set; }
        public virtual Adres AdresKina { get; set; }
      
    }
}
