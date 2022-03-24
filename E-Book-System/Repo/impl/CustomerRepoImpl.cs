using E_Book_System.Areas.Identity.Data;
using E_Book_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Repo.impl
{
    public class CustomerRepoImpl : ICustomerRepo
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepoImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<E_Book_SystemUser> GetAllCustomers()
        {
            var customers = _context.Users.ToList();
            
           return customers;
        }
    }
}
