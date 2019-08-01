﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapPractice.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}