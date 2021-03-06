﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime Timespan { get; private set; }

        public virtual Post Post { get; set; }

        public virtual ApplicationUser User { get; set; }

        public Comment()
        {
            Timespan = DateTime.Now;
        }
    }
}
