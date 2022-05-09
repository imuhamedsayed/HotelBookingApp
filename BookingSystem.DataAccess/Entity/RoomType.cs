using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.DAL.Entity
{
    public class RoomType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public double PricePerNight { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
