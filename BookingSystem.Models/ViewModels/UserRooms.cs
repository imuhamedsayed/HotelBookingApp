using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.BLL.ViewModels
{
    public class UserRooms
    {
        
        public int Id { get; set; }
        public string UserName { get; set; }
        public int RoomId { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        public int NightNo { get; set; }
        public double TotalPrice { get; set; }
    }
}
