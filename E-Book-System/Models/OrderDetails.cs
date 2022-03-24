using E_Book_System.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Models
{
    public class OrderDetails
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderDetailsID { get; set; }


        public decimal subTotal { get; set; }


        public int Qty { get; set; }


        [ForeignKey("Book")]
        public string BookID { get; set; }
        public virtual Book Book { get; set; }


        [ForeignKey("Order")]
        public string orderId { get; set; }
        public virtual Order order { get; set; }
    }
}
