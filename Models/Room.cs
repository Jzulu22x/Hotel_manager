using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_manager.Models;
[Table("rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_number")]
    public required string RoomNumber { get; set; }

    [Column("room_type_id")]
    public int RoomTypeId { get; set; }

    [Column("price_per_night")]
    public double PricePerNight { get; set; }

    [Column("availability")]
    public bool Availability { get; set; }

    [Column("max_occupancy_persons")]
    public byte MaxOccupancyPersons { get; set; }

    [ForeignKey("RoomTypeId")]
    public Room_type? RoomType { get; set; }
}
