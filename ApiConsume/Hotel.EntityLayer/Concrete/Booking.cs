﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EntityLayer.Concrete
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string AdultCount { get; set; }
        public string ChildrenCount { get; set; }
        public string Room { get; set; }
        public string SpecialRequest { get; set; }
        public bool Status { get; set; }
    }
}
