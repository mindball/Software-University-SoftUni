﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class ArticleViewModel
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public string Content { get; set; }

        [Reqiered]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Reqiered]
        public string AuthorId { get; set; }

        public List<Category> Categories { get; set; }

        public string Tags { get; set; }
    }
}