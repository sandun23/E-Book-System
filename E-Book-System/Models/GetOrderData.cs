using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Models
{
    public class GetOrderData
    {
        public GetOrderData(string fullname, int qty, decimal price, string phoneNumber, string address)
        {
            Fullname = fullname;
            this.qty = qty;
            this.price = price;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string Fullname { get; set; }
        public int qty { get; set; }
        public decimal price { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
