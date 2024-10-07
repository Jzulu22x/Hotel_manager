using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Controllers.V1.Room_types;
[ApiController]
[Route("api/v1/room_types")]
[Tags("room_types")]
public class Room_typeGetController : Room_typeController
{
    public Room_typeGetController (IRoom_typeRepository roomtypeRepository) : base(roomtypeRepository)
    {

    }

    [HttpGet]
    public async Task<IEnumerable<Room_type>> GetAllRoom_Types()
    {
        return await _roomtypeRepository.GetAll();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Room_type>> GetRoom_TypeById( [FromRoute] int id)
    {
        var room_type = await _roomtypeRepository.GetById(id);
        if (room_type == null)
        {
            return NotFound("Any value found");
        }
        return room_type;
    }
}