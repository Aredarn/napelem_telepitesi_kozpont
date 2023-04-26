using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.Backend.Modells_Tables
{
    public class Polc
    {
        [Key]
        public int ShelfID { get; set; }
        public int ShelfCalculatedID
        {
            get
            {
                return (Row - 1) + ((Column - 1) * 5) + Level;
            }
        }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Level { get; set; }
        public int ItemsInShelf { get; set; }
        [ForeignKey("Arucikk")]
        public int ArucikkID { get; set; }
    }

}

