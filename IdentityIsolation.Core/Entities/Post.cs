﻿using System.ComponentModel.DataAnnotations;

namespace IdentityIsolation.Core.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
