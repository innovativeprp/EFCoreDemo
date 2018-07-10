using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class PersonalLibrary
    {
        [Required]
        public int Id { get; set; }

        public int ClientId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public Client Client { get; set; }
    }
}
