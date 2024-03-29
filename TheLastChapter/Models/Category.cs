﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheLastChapter.Models
{
    public class Category
    {
        // pk fields should always be called either {Model}Id or just Id
        public int CategoryId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Don't forget me!")]
        public string Name { get; set; }

        // child ref
        public List<Book> Books { get; set; }
    }
}
