using HallBooking_DataLayer.Interfaces;
using HallBooking_Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallBooking_DataLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public HallBookingModel _context = null;
        public DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new HallBookingModel();
            table = _context.Set<T>();
        }
        public GenericRepository(HallBookingModel _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.AsNoTracking().ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            //table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Detach(T obj)
        {
            _context.Entry(obj).State = EntityState.Detached; ;
        }
    }
}
