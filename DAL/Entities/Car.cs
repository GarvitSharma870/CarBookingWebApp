using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Car : BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public string CarName { get; set; }
        [Required]

        public string Number { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]
        public int Slots { get; set; }

        [Required]
        public DateTime AvailabilityFrom { get; set; }
        [Required]
        public DateTime AvailabilityTo { get; set; }
        public Boolean IsActive { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public string UserId {  get; set; }
        public virtual User User {  get; set; }

        public virtual ICollection<CarBooking>? Bookings { get; set; }
    }
}
