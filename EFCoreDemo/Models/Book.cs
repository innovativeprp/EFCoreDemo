using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(32)]
        public string Title { get; set; }
        public string  Author { get; set; }
        public string Isbn { get; set; }
        
        public string TestProperty
        {
            get
            {
                return $"{Author} - {Title}";
            }
        }
    }
}
