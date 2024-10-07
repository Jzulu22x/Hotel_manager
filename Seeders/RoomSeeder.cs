using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Seeders;
public class RoomSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>().HasData(
            new Room { Id = 1, RoomNumber = "101", RoomTypeId = 1, PricePerNight = 50,  Availability = true, MaxOccupancyPersons = 1},
            new Room { Id = 2, RoomNumber = "102", RoomTypeId = 2, PricePerNight = 80,  Availability = true, MaxOccupancyPersons = 2},
            new Room { Id = 3, RoomNumber = "103", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2},
            new Room { Id = 4, RoomNumber = "104", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4}
        );
    }
}
