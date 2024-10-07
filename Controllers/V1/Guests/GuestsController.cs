using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_manager.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hotel_manager.Controllers.V1.Guests
{
    [ApiController]
    [Route("api/v1/guests")]
    public class GuestsController : ControllerBase
    {
        protected readonly IGuestRepository _guestRepository;

        public GuestsController(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }
    }
}