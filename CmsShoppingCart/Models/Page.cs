﻿using System.ComponentModel.DataAnnotations;

namespace CmsShoppingCart.Models
{
    public class Page
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2,ErrorMessage ="min lenght is 2")]
        public string Title { get; set; }
        
        public string Slug { get; set; }
        [Required]
        [MinLength(4, ErrorMessage = "min lenght is 4")]
        public string Content { get; set; }
        public int Sorting { get; set; }


    }
}
