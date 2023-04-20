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

        public int ProjectID { get; set; }

        [ForeignKey("ProjectID")]
        public virtual Projektek Project { get; set; }

        public int StatusID { get; set; }

        [ForeignKey("StatusID")]
        public virtual Status Status { get; set; }

        public DateTime Date { get; set; }
    }
}
