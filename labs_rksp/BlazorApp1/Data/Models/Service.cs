﻿using BlazorApp1.Data.Models;
namespace BlazorApp1.Data.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int[] Order { get; set; }
    }
}
