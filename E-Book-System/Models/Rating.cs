using E_Book_System.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Models
{
    public class Rating
    {

        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string RateID { get; set; }



        public int StarCount { get; set; }
        public string Comments { get; set; }


        [ForeignKey("Book")]
        public string BookID { get; set; }
        public virtual Book Book { get; set; }


        [ForeignKey("E_Book_SystemUser")]
        public string userID { get; set; }
        public virtual E_Book_SystemUser user { get; set; }

    }
}
