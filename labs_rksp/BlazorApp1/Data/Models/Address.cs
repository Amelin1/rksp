﻿using BlazorApp1.Data.Models;
namespace BlazorApp1.Data.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string  City { get; set; }
        public string Street { get; set; }
        public int HomeNumber { get; set; }
        public int[] Order { get; set; }
        
    }
}
