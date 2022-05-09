using System;
using System.Collections.Generic;

namespace BookingSystem.DAL.Entity
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public IEnumerable<Branch> Branches { get; set; }

    }
}