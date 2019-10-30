
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Repositories;

namespace WebApi
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private DataContext _context;
         private GenericRepository<User> UserRepositroy;
 
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        ///// <summary>
        ///// Get/Set Property for Order repository.
        ///// </summary>
        GenericRepository<User> IUnitOfWork.UserRepositroy
        {
            get
            {
                if (this.UserRepositroy == null)
                    this.UserRepositroy = new GenericRepository<User>(_context);
                return UserRepositroy;
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
