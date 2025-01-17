﻿using System.ComponentModel.DataAnnotations;

namespace LMSBackend.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string? CategoryName { get; set; }
        public required ICollection<Books> Books { get; set; }
    }
}
