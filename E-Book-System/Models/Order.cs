using E_Book_System.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Models
{
    public class Order
    {

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderID { get; set; }

        [Required(ErrorMessage ="Requried")]
        public decimal price { get; set; }
        
        [Required(ErrorMessage = "Requried")]
        public int Qty { get; set; }  
        
        public string OrderStatus { get; set; }

        [ForeignKey("E_Book_SystemUser")]
        public string userID { get; set; }
        public virtual E_Book_SystemUser user { get; set; }

    }
}
