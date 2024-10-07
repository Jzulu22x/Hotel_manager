using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Controllers.V1.Room_types;

[ApiController]
[Route("api/v1/room_types")]
public class Room_typeController : ControllerBase
{
    protected readonly IRoom_typeRepository _roomtypeRepository;

    public Room_typeController(IRoom_typeRepository roomtypeRepository)
    {
        _roomtypeRepository = roomtypeRepository;
    }
}
