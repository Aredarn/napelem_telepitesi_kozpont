using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class User
    {
        [Key]
        public string Name { get; set; }
        public byte[] Password { get; set; }
        public int Role { get; set; }
    }
}
