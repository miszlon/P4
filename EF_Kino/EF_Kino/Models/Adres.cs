using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public int NumerDomu { get; set; }
        public int NumerTelefonu { get; set; }
        public string Email { get; set; }
        public virtual Kino Kino { get; set; }

       }
}
