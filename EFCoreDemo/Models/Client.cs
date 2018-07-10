using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Client
    {

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }      

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public Membership Membership { get; set; }

        public PersonalLibrary PersonalLibrary { get; set; }
    }
}
