﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawiyaAPI.Models
{
    public class Category
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Description { get; set; }

    }
}
