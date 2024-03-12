using System;
using System.ComponentModel.DataAnnotations;

namespace CateringMS.Models
{
    public class CateringOrder
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string full_name { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        public string phone_number { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "TodaysDate")]
        public DateTime todays_date { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "OrderDueDate")]
        public DateTime order_due_date { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "EventDate")]
        public DateTime event_date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "EventTime")]
        public TimeSpan event_time { get; set; }

        [Required]
        [Display(Name = "Pick-up Location")]
        public string pickup_location { get; set; }

        [Required]
        [Display(Name = "Type of event")]
        public string event_type { get; set; }

        [Required]
        [Display(Name = "Number of guests")]
        public int number_of_guests { get; set; }

        [Required]
        [Display(Name = "Pick up time")]
        public TimeSpan pickup_time { get; set; }

        [Required]
        [Display(Name = "Delivery method")]
        public string delivery_method { get; set; }
    }
}
