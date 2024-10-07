using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;
using Hotel_manager.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Room_type> Room_types {get; set;}
    public DbSet<Room> Rooms {get; set; }
    public DbSet<Guest> Guests {get; set; }
    public DbSet<Employee> Employees { get; set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        RoomTypeSeeder.Seed(modelBuilder);
    }
}
