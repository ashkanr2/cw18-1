﻿namespace cw18_1.Models
{
    public class User
    {

        public int Id{ get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Book>Books { get; set; }
        public Address Address { get; set; }   
        public int AddressId { get; set; }


    }
}
