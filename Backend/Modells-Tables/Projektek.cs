using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class Projektek
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectID { get; set; }

        [ForeignKey("ProjectManager")]
        public string ProjectManagerID { get; set; }

        public virtual Felhasznalo ProjectManager { get; set; }

        [ForeignKey("Client")]
        public string ClientID { get; set; }

        public virtual Felhasznalo Client { get; set; }

        public DateTime ApproxTimeToFinish { get; set; }

        public int ApproxCost { get; set; }


    }
}
