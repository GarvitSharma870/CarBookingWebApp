using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CarBooking : BaseEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Total Price is Required")]
        public double TotalPrice { get; set; }
        [Required]
        public DateTime BookingFrom { get; set; }
        [Required]
        public DateTime BookingTo { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        [Required]
        public int CarId {  get; set; }
        public virtual Car? Car { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
