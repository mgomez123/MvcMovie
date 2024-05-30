﻿using System;
using System.Collections.Generic;

namespace MvcMovie.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? Releasedate { get; set; }

    public string? Genre { get; set; }

    public decimal? Price { get; set; }
}
