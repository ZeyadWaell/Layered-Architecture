using System;
using System.ComponentModel.DataAnnotations;

namespace CleaningDomain.Entities;

public class Map
{
    [Key]
 public int Id { get; set; }
 public string Name { get; set; }
 public int Width { get; set; }
 public int Height { get; set; }
 public int X { get; set; }
 public int Y { get; set; }
 public string Type { get; set; }
 
}
