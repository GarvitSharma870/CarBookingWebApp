﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public virtual ICollection<CarBooking>? BookedCars {  get; set; }
        public virtual ICollection<Car>? CarDetails { get; set; }

    }
}