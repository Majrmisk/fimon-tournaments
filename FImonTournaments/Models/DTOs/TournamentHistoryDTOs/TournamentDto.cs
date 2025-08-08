namespace FImonTournaments.Models.DTOs.TournamentHistoryDTOs;

public sealed class TournamentDto
{
    public required string Name { get; set; }
    public required string StartDateTime { get; set; }
    public required string Type { get; set; }
    public required TournamentTrainerDto Winner { get; set; }
    public required IList<TournamentTrainerDto> Trainers { get; set; }
}