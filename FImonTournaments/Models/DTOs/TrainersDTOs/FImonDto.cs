namespace FImonTournaments.Models.DTOs.TrainersDTOs;

public class FImonDto
{
    public required string Name { get; set; }

    public required int Attack { get; set; }

    public required int Speed { get; set; }

    public required int HP { get; set; }

    public required string Type { get; set; }
}