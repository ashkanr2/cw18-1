﻿namespace cw18_1.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Book> Books { get; set; }
    }
}
