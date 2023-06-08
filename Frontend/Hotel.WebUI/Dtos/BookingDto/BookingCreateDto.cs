using System;

namespace Hotel.WebUI.Dtos.BookingDto
{
    public class BookingCreateDto
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
