using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Data;
using Hotel_manager.Models;
using Hotel_manager.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Services;
public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext _context;

    public RoomServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Room>> GetAll()
    {
        return await _context.Rooms.ToListAsync();
    }

    public async Task<IEnumerable<Room>> GetAviable()
    {
        return await _context.Rooms.Where(r => r.Availability).ToListAsync();
    }

    public async Task<Room?> GetById(int id)
    {
        return await _context.Rooms.FindAsync(id);
    }

    public async Task<IEnumerable<Room>> GetOccupied()
    {
        return await _context.Rooms.Where(r =>!r.Availability).ToListAsync();
    }

    public async Task<int> GetTotal()
    {
        return await _context.Rooms.CountAsync(r => r.Availability);
    }
}