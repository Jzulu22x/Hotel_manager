using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;

namespace Hotel_manager.Repositories;
public interface IRoom_typeRepository
{
    Task<IEnumerable<Room_type>> GetAll();
    Task<Room_type?> GetById(int id);
}
