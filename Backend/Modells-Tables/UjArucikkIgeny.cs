using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class UjArucikkIgeny
    {
        [Key]
        public int AruIgenyID { get; set; }
        public string AruNev { get; set; }
        public int Mennyiseg { get; set; }

        [ForeignKey("Projektek")]
        public int ProjectID { get; set; }
        public virtual Projektek Projektek { get; set; }
    }
}
