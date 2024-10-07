using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_manager.Models;

[Table("guests")]
public class Guest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("first_name")]
    public required string FirstName { get; set; }

    [Column("last_name")]
    public required string LastName { get; set; }

    [Column("email")]
    [EmailAddress]
    public required string Email { get; set; }

    [Column("identidication_number")]
    public required string IdentificationNumber { get; set; }

    [Column("phone_number")]
    [Phone]
    public required string PhoneNumber { get; set; }
        
    [Column("birthdate")]
    public DateTime? Birthdate { get; set; }
}
