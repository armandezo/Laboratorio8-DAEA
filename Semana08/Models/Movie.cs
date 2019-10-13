using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana08.Models
{
    public class Movie
    {
        public int? ID { get; set; }
        public string title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }
    }
}