using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBooking_DataLayer.Interfaces
{
    public interface IStoreRepository: IGenericRepository<Store>
    {
        Store getStore();
    }
}
