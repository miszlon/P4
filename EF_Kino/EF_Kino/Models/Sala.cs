using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Sala
    {
        public int IdSali { get; set; }
        public string Nazwa { get; set; }
        public string LiczbaMiejsc { get; set; }
        public virtual ICollection<Miejsce> Miejsce { get; set; }
        public virtual Kino Kino { get; set; }
    }
}
