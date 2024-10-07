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
public class GuestsGetController : GuestsController
{
    public GuestsGetController(IGuestRepository guestRepository) : base(guestRepository)
    {
        
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Models.Guest>>> GetGuests()
    {
        return Ok(await _guestRepository.GetAll());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Models.Guest>> GetGuestById([FromRoute]int id)
    {
        var guest = await _guestRepository.GetById(id);
        if (guest == null)
        {
            return NotFound();
        }
        return guest;
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Models.Guest>>> SearchGuests([FromRoute] string keyword)
    {
        var result = await _guestRepository.GetByKeyWord(keyword);
        if (result.Count() == 0)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
