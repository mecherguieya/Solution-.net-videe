using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Patient
    {
        [Key]
        [MaxLength(5, ErrorMessage = "La longeur de code nest pas respectee")]
        public int CodePatient { get; set; }
        public string EmailPatient { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Informations supplimentaires")]
        public string Informations { get; set; }
        public string NomComplet { get; set; }
        public string NumeroTel { get; set; }
        //porteuse
        public virtual IList<Bilan> Bilans { get; set; }



    }
}
