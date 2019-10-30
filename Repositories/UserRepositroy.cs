using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi;
using WebApi.Entities;

namespace WebApi.Repositories
{/// <summary>
/// this  repo  is   concerns UnLocked_out_UsersRepositroy 
/// </summary>
    public class UserRepositroy : GenericRepository<User>
    {
        public UserRepositroy(DataContext context) :base(context)
        {

        }
       
  


    }
}