using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string StatusInfo { get; set; }
    }
}
