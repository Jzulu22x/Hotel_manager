
using Hotel_manager.Data;
using Hotel_manager.Models;
using Hotel_manager.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Hotel_manager.Services;
public class Room_typeServices : IRoom_typeRepository
{
    private readonly ApplicationDbContext _context;

    public Room_typeServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Room_type>> GetAll()
    {
        return await _context.Room_types.ToListAsync();
    }

    public async Task<Room_type?> GetById(int id)
    {
        return await _context.Room_types.FindAsync(id);
    }
}
