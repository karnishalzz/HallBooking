namespace HallBooking_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime BookingDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public decimal? PaidAmount { get; set; }

        public decimal? DueAmount { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [StringLength(50)]
        public string Purpose { get; set; }

        public string Status { get; set; }
    }
}
