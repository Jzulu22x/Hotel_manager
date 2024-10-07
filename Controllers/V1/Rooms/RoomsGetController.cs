using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Models;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Controllers.V1.Rooms;

[ApiController]
[Route("api/v1/rooms")]
[Tags("rooms")]
public class RoomsGetController : RoomsController
{
    public RoomsGetController(IRoomRepository roomRepository) : base(roomRepository)
    {

    }

    [HttpGet("available")]
    public async Task<IActionResult> GetAvailableRooms()
    {
        var result = await _roomRepository.GetAvailable();
        if (result == null)
        {
            return NotFound("No available rooms found.");
        }

        else
        {
            return Ok(result);
        }
    }

    [HttpGet("status")]
    public async Task<IActionResult> GetRoomStatus()
    {
        var total = await _roomRepository.GetTotal();
        if (total == 0)
        {
            return Ok("No room found");
        }
        else if (total == 50)
        {
            return Ok("All rooms are available");
        }
        else
        {
            return Ok($"{total} rooms available and {50 - total} occupied");
        }
    }

    [HttpGet]
    public async Task<IEnumerable<Room>> GetAllRoms()
    {
        var result = await _roomRepository.GetAll();
        return result;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Room>> GetRoomById([FromRoute] int id)
    {
        var room = await _roomRepository.GetById(id);
        if (room == null)
        {
            return NotFound($"Room with id {id} not found");
        }
        else
        {
            return Ok(room);
        }
    }

    [HttpGet("occupied")]
    public async Task<IActionResult> GetOccupiedRooms()
    {
        var result = await _roomRepository.GetOccupied();

        // Verificar si se encontraron habitaciones ocupadas
        if (result == null || !result.Any())
        {
            return Ok("No occupied rooms found."); // Devuelve un mensaje de no encontradas
        }

        return Ok(result); // Devuelve la lista de habitaciones ocupadas
    }

}