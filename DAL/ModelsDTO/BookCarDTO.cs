using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ModelsDTO
{
    public class BookCarDTO
    {
        [Required(ErrorMessage = "Total Price is Required")]
        public double TotalPrice { get; set; }
        [Required(ErrorMessage ="Booking Duration is Required ")]
        public List<DateTime> BookedDuration { get; set; }
        public int Offset { get; set; }
        [Required(ErrorMessage = "Company Id is Required")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Car Id is Required")]
        public int CarId { get; set; }
    }
}
