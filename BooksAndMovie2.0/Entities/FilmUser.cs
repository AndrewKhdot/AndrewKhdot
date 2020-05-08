﻿using BooksAndMovie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAndMovie2._0.Entities
{
   
        public class FilmUser
        {
            public int UserId { get; set; }
            public User User { get; set; }

            public int FilmId { get; set; }
            public Film Film { get; set; }
            public int? Rating { get; set; }

        }
    
}