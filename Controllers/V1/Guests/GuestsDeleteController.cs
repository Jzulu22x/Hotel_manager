using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Controllers.V1.Guests;

[ApiController]
[Route("api/v1/guests")]
[Tags("guests")]
public class GuestsDeleteController : GuestsController
{
    public GuestsDeleteController(IGuestRepository guestRepository) : base(guestRepository)
    {
        
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var guest = await _guestRepository.GetById(id);
        if (guest == null)
        {
            return NotFound();
        }
        await _guestRepository.DeleteGuest(id);
        return Ok("Guest has been deleted");
    }
}