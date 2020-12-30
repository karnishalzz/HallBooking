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
    public class ExpenseService
    {
        private IGenericRepository<Expense> _repository = null;


        public ExpenseService()
        {
            _repository = new GenericRepository<Expense>();
            
        }

    
        public List<Expense> GetAll()
        {
            return (List<Expense>)_repository.GetAll();
        }
        public Expense GetById(int id)
        {
            return _repository.GetById(id);

        }

        public void Insert(Expense item)
        {
            _repository.Insert(item);
            _repository.Save();
        }
        public void Update(Expense item)
        {
            _repository.Update(item);
            _repository.Save();
        }
        public void Delete(Expense item)
        {
            _repository.Delete(item.Id);
            _repository.Save();
        }


    }
}
