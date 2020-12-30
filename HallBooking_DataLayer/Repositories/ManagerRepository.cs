using HallBooking_DataLayer.Interfaces;
using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBooking_DataLayer.Repositories
{
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public Manager GetByUsername(string name, string pass)
        {
            return _context.Managers
                .Where(u => u.Username == name && u.Password == pass)
                .FirstOrDefault();
        }
        public List<Manager> GetUserByRole(string role)
        {
            return _context.Managers
                .Where(u => u.Role == role)
                .OrderBy(u => u.Username)
                .ToList();
        }
        public bool IsExist(string user)
        {
            var item = _context.Managers.Where(u => u.Username == user).FirstOrDefault();
            if (item != null) return true;
            else return false;

        }
        public Manager GetUser(string name)
        {
            return _context.Managers.Where(u => u.Username == name).FirstOrDefault();
        }
    }
}
