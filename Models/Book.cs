using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublishingHouse { get; set; }
        public int YearPublication { get; set; }
    }
}
