using E_Book_System.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Repo
{
   public interface ICustomerRepo
    {

        IEnumerable<E_Book_SystemUser> GetAllCustomers();

    }
}
