﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectTorrent.Models
{
    public class Movies
    {
        public int MovieCount { get; set; }
        public List<Movie> MovieList { get; set; }
    }
}