using Hotel_manager.Data;
using Hotel_manager.DTOs;
using Hotel_manager.Models;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Services;
public class GuestServices : IGuestRepository
{
    private readonly ApplicationDbContext _context;

    public GuestServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Add(GuestDTO guestDto)
    {
        var guest = new Guest
        {
            FirstName = guestDto.FirstName,
            LastName = guestDto.LastName,
            Email = guestDto.Email,
            IdentificationNumber = guestDto.IdentificationNumber,
            PhoneNumber = guestDto.PhoneNumber,
            Birthdate = guestDto.Birthdate
        };

        _context.Add(guest);

        return await _context.SaveChangesAsync();
    }

    public async Task DeleteGuest(int id)
    {
        var guest = await _context.Guests.FindAsync(id);

        _context.Guests.Remove(guest);
        await _context.SaveChangesAsync();

    }


    public async Task<IEnumerable<Guest>> GetAll()
    {
        return await _context.Guests.ToListAsync();
    }

    public async Task<Guest?> GetById(int id)
    {
        return await _context.Guests.FindAsync(id);
    }

    public async Task<IEnumerable<Guest>> GetByKeyWord(string keyword)
    {
        return await _context.Guests.Where(g => g.FirstName.Contains(keyword) || g.LastName.Contains(keyword)).ToListAsync();
    }

    public async Task<Guest> UpdateGuestAsync(int id, Guest guest)
    {
        var existingGuest = await _context.Guests.FindAsync(id);

        if (existingGuest != null)
        {
            existingGuest.FirstName = guest.FirstName;
            existingGuest.LastName = guest.LastName;
            existingGuest.Email = guest.Email;
            existingGuest.IdentificationNumber = guest.IdentificationNumber;
            existingGuest.PhoneNumber = guest.PhoneNumber;
            existingGuest.Birthdate = guest.Birthdate;

            await _context.SaveChangesAsync();

            return existingGuest;
        }

        return null;
    }
}
