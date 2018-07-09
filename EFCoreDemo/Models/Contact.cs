using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class Contact:BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string StreetName { get; set; }

        public int StreetNumber { get; set; }

        public int PostalCode { get; set; }
    }
}
