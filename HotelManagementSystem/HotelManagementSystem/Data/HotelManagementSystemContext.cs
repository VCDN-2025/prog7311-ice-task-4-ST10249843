using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Data
{
    public class HotelManagementSystemContext : DbContext
    {
        public HotelManagementSystemContext (DbContextOptions<HotelManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<HotelManagementSystem.Models.Booking> Booking { get; set; } = default!;
    }
}
