using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Bilan
    {
        public DateTime DatePrelevement { get; set; }

        public string EmailMedecin { get; set; }
        public bool Paye { get; set; }

        public virtual IList<Analyse> Analyses { get; set; }

        //porteuse
        public virtual Infirmier Infirmier { get; set; }

        public virtual Patient Patient { get; set; }

    }
}
