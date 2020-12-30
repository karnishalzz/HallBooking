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
    public class ManagerService
    {
        private IGenericRepository<Manager> _repository = null;
        private IManagerRepository _managerRepository = null;
        public ManagerService()
        {
            _repository = new GenericRepository<Manager>();
            _managerRepository = new ManagerRepository();

        }
        public Manager GetByUsername(string name, string pass)
        {
            var user = _managerRepository.GetByUsername(name, pass);
            return user;
        }
        public Manager GetUser(string name)
        {
            var user = 
                _managerRepository.GetUser(name);
            return user;
        }
        public List<Manager> GetUserByRole(string role)
        {
            var users = (List<Manager>)_managerRepository.GetUserByRole(role);
            return users;
        }
        public bool IsExist(string user)
        {
            return _managerRepository.IsExist(user);
        }
        public List<Manager> GetAll()
        {
            return (List<Manager>)_repository.GetAll();
        }
        public Manager GetById(int id)
        {
            return _repository.GetById(id);

        }

        public void Insert(Manager manager)
        {
            _repository.Insert(manager);
            _repository.Save();
        }
        public void Update(Manager item)
        {
            _repository.Update(item);
            _repository.Save();
        }
        public void Delete(Manager item)
        {
            _repository.Delete(item.Id);
            _repository.Save();
        }

    }
}
