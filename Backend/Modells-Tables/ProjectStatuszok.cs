using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class ProjectStatuszok
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateID { get; set; }

        [ForeignKey("Projektek")]

        public int ProjectID { get; set; }

        [ForeignKey("Status")]
        public int StatusID { get; set; }
                
        public DateTime FazisKezdete { get; set; }
    }
}
