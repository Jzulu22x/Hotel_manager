using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;

namespace Hotel_manager.Repositories;
public interface IRoomRepository
{
    Task<IEnumerable<Room>> GetAviable();
    Task<int> GetTotal();
    Task<IEnumerable<Room>> GetAll();
    Task<Room> GetById(int id);
    Task<IEnumerable<Room>> GetOccupied();
}