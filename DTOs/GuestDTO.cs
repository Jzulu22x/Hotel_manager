using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_manager.DTOs;
public class GuestDTO
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    [EmailAddress]
    public required string Email { get; set; }

    public required string IdentificationNumber { get; set; }

    [Phone]
    public required string PhoneNumber { get; set; }

    public DateTime? Birthdate { get; set; }
}



