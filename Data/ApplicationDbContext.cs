using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Data;
public class ApplicationDbContext : DbContext
{
    DbSet<Room_type> Room_types {get; set;}
    DbSet<Room> Rooms {get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
