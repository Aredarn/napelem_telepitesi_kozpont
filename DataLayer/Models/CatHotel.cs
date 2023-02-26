using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napelem_telepito_kozpont.DataLayer.Models
{
    public class CatHotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string HotelName { get; set; }
        public string Location { get; set; }
        public List<Cat> Guests { get; set; }
    }
}
