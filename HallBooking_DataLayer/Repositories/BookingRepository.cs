using HallBooking_DataLayer.Interfaces;
using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBooking_DataLayer.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
    }
}
