using HallBooking_DataLayer.Interfaces;
using HallBooking_DataLayer.Repositories;
using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_HallBooking.Services
{
    public class BookingService
    {
        private IGenericRepository<Booking> _repository = null;
        private IBookingRepository _bookingRepository = null;

        public BookingService()
        {
            _repository = new GenericRepository<Booking>();
            _bookingRepository = new BookingRepository();
        }
     
        //public List<Brand> GetBrandBySearch(string name)
        //{
        //    var brands = _brandRepository.GetBrandBySearch(name);
        //    return brands;
        //}

        public List<Booking> GetAll()
        {
            return (List<Booking>)_repository.GetAll();
        }
        public Booking GetById(int id)
        {
           return  _repository.GetById(id);

        }

        public void Insert(Booking booking)
        {
            _repository.Insert(booking);
            _repository.Save();
        }
        public void Update(Booking booking)
        {
            _repository.Update(booking);
            _repository.Save();
        }
        public void Delete(Booking booking)
        {
            _repository.Delete(booking.Id);
            _repository.Save();
        }


    }
}
