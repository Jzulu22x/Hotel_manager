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
public class GuestsPostController : GuestsController
{
    public GuestsPostController(IGuestRepository guestRepository) : base(guestRepository)
    {
        
    }

    [HttpPost]
    public async Task<IActionResult> CreateGuest(GuestDTO guests)
    {
        await _guestRepository.Add(guests);
        return Ok("User added successfully");
    }

}
