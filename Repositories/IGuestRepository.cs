using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.DTOs;
using Hotel_manager.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Repositories;
public interface IGuestRepository
{
    Task<int> Add(GuestDTO guest);
    Task <IEnumerable<Guest>> GetAll();
    Task<Guest?> GetById(int id);
    Task DeleteGuest (int id);
    Task <IEnumerable<Guest>> GetByKeyWord(string keyword);
    Task<Guest> UpdateGuestAsync(int id, Guest guest);
}
