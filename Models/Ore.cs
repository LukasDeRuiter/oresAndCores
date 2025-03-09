using System.ComponentModel.DataAnnotations;

namespace oresAndCores.Models;

public class OreController
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Value { get; set; }
}