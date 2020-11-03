using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldNews.Models
{
    public class ContactUs
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Message { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
      
    }
}
