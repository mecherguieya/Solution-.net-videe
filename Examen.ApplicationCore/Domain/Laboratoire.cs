﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Laboratoire
    {
        
        public string Intitule { get; set; }

        public int LaboratoireId { get; set; }
        public string Localisation { get; set; }

        public virtual IList<Infirmier> Infirmiers { get; set; }


    }
}