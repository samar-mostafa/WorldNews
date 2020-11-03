using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldNews.Models
{
    public class News
    {
        [Required]
    
        public int Id { get; set; }

        [Required]
    
        public string  Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public string  NewImage { get; set; }

        [Required]
        
        public string Topic { get; set; }



        public string Disc { get; set; }


        public virtual Category Category  { get; set; }
        public int CategoryId { get; set; }
    }
}
