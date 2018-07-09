using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class ToDo:BaseEntity
    {
        [Required]
        public string  Text { get; set; }

        [Required]
        public bool Completed { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime CompletedAt { get; set; }
    }
}
