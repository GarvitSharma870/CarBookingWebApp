using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Company : BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<CarBooking> Bookings { get; set;}
    }
}
