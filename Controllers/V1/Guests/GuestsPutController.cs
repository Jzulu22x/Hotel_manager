using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.DTOs;
using Hotel_manager.Models;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Controllers.V1.Guests;

[ApiController]
[Route("api/v1/guests")]
[Tags("guests")]
public class GuestsPutController : GuestsController
{
    public GuestsPutController(IGuestRepository guestRepository) : base(guestRepository)
    {

    }

     [HttpPut("{id}")]
    public async Task<IActionResult> UpdateGuest(int id, Guest guest)
    {
        var updatedGuest = await _guestRepository.UpdateGuestAsync(id, guest);

        if (updatedGuest != null)
        {
            return Ok(updatedGuest); // Devuelve el Guest actualizado
        }

        return NotFound($"Guest with ID {id} not found."); // Devuelve 404 si no se encuentra
    }
}
