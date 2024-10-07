using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Seeders;
public class RoomTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room_type>().HasData(
            new Room_type { Id = 1, Name = "Habitación Simple", Description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos." },
            new Room_type { Id = 2, Name = "Habitación Doble", Description = "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos." },
            new Room_type { Id = 3, Name = "Suite", Description = "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad." },
            new Room_type { Id = 4, Name = "Habitación Familiar", Description = "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda." }
        );
    }
}
