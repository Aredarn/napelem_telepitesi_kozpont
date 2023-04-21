using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class ProjektArucikkhez
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectToItemID { get; set; }
        public int Quantity { get; set; }
        public bool IsReserved { get; set; }

        [ForeignKey("Projektek")]
        public int ProjectID { get; set; }

        [ForeignKey("Arucikknev")]
        public string Arucikknev { get; set; }

    }

}
