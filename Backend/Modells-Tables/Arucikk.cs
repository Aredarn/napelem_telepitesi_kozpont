using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class Arucikk
    {
        [Key]
        public string Arucikknev { get; set; }
        public int Price { get; set; }
        public int MaxOnShelf { get; set; }
    }
}
