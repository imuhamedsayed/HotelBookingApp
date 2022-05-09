using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.DAL.Entity
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int BranchId { get; set; }
        public int TypeId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public Branch Branch { get; set; }
        [ForeignKey(nameof(TypeId))]
        public RoomType Type { get; set; }
        public IEnumerable<UserRooms> UserRooms { get; set; }
    }
}
