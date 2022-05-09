using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingSystem.BLL.ViewModels
{
    public class Branch
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int HotelId { get; set; }
       
        public Hotel Hotel { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
    }
}
