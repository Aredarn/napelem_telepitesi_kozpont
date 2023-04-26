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

        [ForeignKey("Felhasznalo")]
        public int FelhasznaloID { get; set; }

        [ForeignKey("Megrendelo")]
        public int ClientID { get; set; }

        public string leiras { get; set; }

        public string helyszin { get; set; }

        [Required]
        public DateTime ApproxTimeToFinish { get; set; }

        public int ApproxCost { get; set; }

    }

}
