namespace Base_Model.Model.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }

        public string BookingName { get; set; }

        public string BookingDescription { get; set; }

        public string BookingPhone { get; set; }

        public string BookingEmail { get; set; }

        public int PersonCount { get; set; } 

        public DateTime BookingDate { get; set; }   
    }
}
