using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public enum Specialite
    {
        Hematologue,
        Biochimie,
        Autre
    }
    public class Infirmier
    {
        public int InfirmierId { get; set; }
        public string NomComptet { get; set; }
        public Specialite Specialie { get; set; }

        public virtual Laboratoire Laboratoire { get; set; }
        //porteuse
        public virtual IList<Bilan> Bilans { get; set; }



    }
}
