﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        public string title;
        public List<Evento> eventi;

        public ProgrammaEventi(string title, List<Evento> eventi)
        {
            this.title = title;
            this.eventi = new List<Evento>();
        }
    }


}
