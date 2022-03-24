using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BookID { get; set; }

        [Required]
        [StringLength(100)]
        public string BookName { get; set; }

        [Required]
        [StringLength(1000)]
        public string BookDesc { get; set; }

        [Required]
        public Decimal BookPrice { get; set; }

        [Required]
        [StringLength(100)]
        public string BookAuthorName { get; set; }

        [Required]
        [StringLength(100)]
        public string BookCategory { get; set; }
        
        
        [StringLength(100)]
        public string BookImageFileName { get; set; }   

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile BookImageFile{ get; set; }

        [Required]
        [StringLength(100)]
        public string BookType { get; set; }

        [Required]
        public int BookQty { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime Created_at { get; set; }

        public Book()
        {
            Created_at = DateTime.Now;
        }
    }
}
