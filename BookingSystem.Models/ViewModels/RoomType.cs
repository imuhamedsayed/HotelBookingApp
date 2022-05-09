using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.BLL.ViewModels
{
    public class RoomType
    {
       
        public int Id { get; set; }
        public string Type { get; set; }
        public double PricePerNight { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
