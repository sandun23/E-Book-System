using E_Book_System.Data;
using E_Book_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Repo.impl
{
    public class OrderRepoImpl : IOrderRepo
    {
        private readonly ApplicationDbContext _context;

        public OrderRepoImpl(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<GetOrderData> GetAllOrderDetails()
        {
           
            var orderData = (from o in _context.Orders
                              from u in _context.Users
                              where o.userID == u.Id 
                              select new
                              {
                                  Fullname = u.FullName,
                                  PhoneNumber = u.PhoneNumber,
                                  Address = u.Address,
                                  price = o.price,
                                  qty = o.Qty
                              }).ToList();

            List<GetOrderData> getOrderDatas = new List<GetOrderData>();

            foreach(var details in orderData)
            {
                getOrderDatas.Add(new GetOrderData(details.Fullname, details.qty,details.price, details.PhoneNumber, details.Address));
            }
           // GetOrderData orderDatas = new GetOrderData(orderData);
            return getOrderDatas;
        }
    }
}
