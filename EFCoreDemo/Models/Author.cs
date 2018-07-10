using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Author
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public string Nationality { get; set; }

        public List<Book> Books { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName}  {LastName}";
            }
        }
    }
}
