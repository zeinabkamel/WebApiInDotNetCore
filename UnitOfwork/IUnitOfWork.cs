


using WebApi.Entities;

namespace WebApi
{
    public interface IUnitOfWork
    {
        GenericRepository<User> UserRepositroy { get; }

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
   
       

 
        
 
    }
}
