using System;

namespace Portfolio.API.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddDateTime { get; set; }
    }
}