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

            new Room { Id = 1, RoomNumber = "101", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 2, RoomNumber = "102", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 3, RoomNumber = "103", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 4, RoomNumber = "104", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 5, RoomNumber = "105", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 6, RoomNumber = "106", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 7, RoomNumber = "107", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 8, RoomNumber = "108", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 9, RoomNumber = "109", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 10, RoomNumber = "110", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },

            new Room { Id = 11, RoomNumber = "201", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 12, RoomNumber = "202", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 13, RoomNumber = "203", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 14, RoomNumber = "204", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 15, RoomNumber = "205", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 16, RoomNumber = "206", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 17, RoomNumber = "207", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 18, RoomNumber = "208", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 19, RoomNumber = "209", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 20, RoomNumber = "210", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },

            new Room { Id = 21, RoomNumber = "301", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 22, RoomNumber = "302", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 23, RoomNumber = "303", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 24, RoomNumber = "304", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 25, RoomNumber = "305", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 26, RoomNumber = "306", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 27, RoomNumber = "307", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 28, RoomNumber = "308", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 29, RoomNumber = "309", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 30, RoomNumber = "310", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },

            new Room { Id = 31, RoomNumber = "401", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 32, RoomNumber = "402", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 33, RoomNumber = "403", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 34, RoomNumber = "404", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 35, RoomNumber = "405", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 36, RoomNumber = "406", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 37, RoomNumber = "407", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 38, RoomNumber = "408", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 39, RoomNumber = "409", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 40, RoomNumber = "410", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },

            new Room { Id = 41, RoomNumber = "501", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 42, RoomNumber = "502", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 43, RoomNumber = "503", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 44, RoomNumber = "504", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 45, RoomNumber = "505", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 46, RoomNumber = "506", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 47, RoomNumber = "507", RoomTypeId = 3, PricePerNight = 150, Availability = true, MaxOccupancyPersons = 2 },
            new Room { Id = 48, RoomNumber = "508", RoomTypeId = 4, PricePerNight = 200, Availability = true, MaxOccupancyPersons = 4 },
            new Room { Id = 49, RoomNumber = "509", RoomTypeId = 1, PricePerNight = 50, Availability = true, MaxOccupancyPersons = 1 },
            new Room { Id = 50, RoomNumber = "510", RoomTypeId = 2, PricePerNight = 80, Availability = true, MaxOccupancyPersons = 2 }

        );
    }
}
