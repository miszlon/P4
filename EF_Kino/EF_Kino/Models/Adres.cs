﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Kino.Models
{
    public class Adres
    {
        public int IdAdresu { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public int NumerDomu { get; set; }
        public int NumerTelefonu { get; set; }
        public string Email { get; set; }
        public Kino Kino { get; set; }

       }
}
