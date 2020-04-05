using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Kino
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public virtual Adres Adres { get; set; }

    }
}
