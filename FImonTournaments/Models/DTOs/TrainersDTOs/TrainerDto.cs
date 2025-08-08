namespace FImonTournaments.Models.DTOs.TrainersDTOs;

public class TrainerDto
{
    public required int ID { get; set; }

    public required string Name { get; set; }

    public required int BattlesWon { get; set; }

    public required int TotalBattles { get; set; }

    public required int TournamentsWon { get; set; }

    public required List<FImonDto> FImons { get; set; }
}
