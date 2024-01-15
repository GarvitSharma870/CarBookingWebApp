using DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace DAL.DTO
{
    public class CarDTO
    {
        [Required(ErrorMessage = "Car Name is Required")]
        public string CarName { get; set; }
        [Required(ErrorMessage = "Car Number is Required")]

        public string Number { get; set; }
        [Required(ErrorMessage = "Price Field is Required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Slot Field is Required")]
        public int Slots { get; set; }
        public int Offset { get; set; }

        [Required(ErrorMessage = "Availability Time is Required")]
        public List<DateTime> AvailableTime { get; set; }

        public int CompanyId { get; set; }

        public string? UserId { get; set; }
    }
}
