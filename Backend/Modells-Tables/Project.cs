using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectManager { get; set; }
        public int StatusID { get; set; }

        [ForeignKey("Projectmanager")]
        public User User { get; set; }

        [ForeignKey("StatusID")]
        public Status Status { get; set; }
    }
}
