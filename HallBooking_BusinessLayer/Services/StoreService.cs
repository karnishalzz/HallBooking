using HallBooking_DataLayer.Interfaces;
using HallBooking_DataLayer.Repositories;
using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBooking_BusinessLayer.Services
{
    public class StoreService
    {
        private IGenericRepository<Store> _repository = null;
        private IStoreRepository _storeRepository = null;

        public StoreService()
        {
          
            _repository = new GenericRepository<Store>();
            _storeRepository = new StoreRepository();
        }
        public Store GetStore()
        {
            var store = _storeRepository.getStore();
            return store;
        }
        public Store GetById(int id)
        {
            var store = _repository.GetById(id);
            return store;
        }

        public void Insert(Store store)
        {
            _repository.Insert(store);
            _repository.Save();
        }
        public void Update(Store store)
        {
            _repository.Update(store);
            _repository.Save();
        }
    }

}