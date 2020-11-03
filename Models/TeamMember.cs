using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldNews.Models
{
    public class TeamMember
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(40)]
       public string JobTitle { get; set; }

        [Required]
        public string Image { get; set; }
    }
}
