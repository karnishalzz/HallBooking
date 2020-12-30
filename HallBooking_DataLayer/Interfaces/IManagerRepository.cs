using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBooking_DataLayer.Interfaces
{
    public interface IManagerRepository : IGenericRepository<Manager>
    {
        Manager GetByUsername(string name, string pass);
        Manager GetUser(string name);
        List<Manager> GetUserByRole(string role);
        bool IsExist(string user);
    }
}
