using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string CellNum { get; set; }

        [EmailAddress]
        public string email { get; set; }


        //*****************************************************

        [Required]
        [Range(0,4)]
        public int Adult { get; set; }

        [Required]
        [Range(0, 4)]
        public int Children { get; set; }
        public string RoomType { get; set; } 

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
