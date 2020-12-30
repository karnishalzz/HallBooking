namespace HallBooking_Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

    public partial class HallBookingModel : DbContext
    {
        public HallBookingModel()
            : base("name=HallBookingModel")
        {
        }

    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Store> Stores { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Booking>()
                .Property(e => e.Time)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.CustomerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.CustomerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Booking>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Expense>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.JoiningDate)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Manager>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
