using BookingSystem.DAL.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BookingSystem.DAL.DatabaseContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
       
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<UserRooms> UserRooms { get; set; }
    }
}
