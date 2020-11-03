using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldNews.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Discription { get; set; }

        [Required]
        public List<News> News { get; set; }

        public string  CatImg { get; set; }
        
    }
}
