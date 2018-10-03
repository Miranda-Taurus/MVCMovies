using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCWebApp.Models
{
    public class MovieGenreViewModel
    {
        public decimal Price { get; set; }
        public List<Movie> movies;
        public SelectList genres;
        public String movieGenre { get; set; }
    }
}
