﻿using System.ComponentModel.DataAnnotations;

namespace MyWebApi;

public class VillaDTO
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }
    public int Sqft { get; set; }

    public string Details { get; set; }

    [Required]
    public double Rate { get; set; }

    public string ImageUrl { get; set; }

    public string Amenity { get; set; }

    public string Occupancy { get; set; }
}
