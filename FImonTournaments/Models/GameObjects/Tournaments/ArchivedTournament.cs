using FImonTournaments.Models.DTOs.TournamentHistoryDTOs;
using FImonTournaments.Utils;

namespace FImonTournaments.Models.GameObjects.Tournaments;

public class ArchivedTournament
{
    public required string Name { get; set; }
    public required DateTime StartDateTime { get; set; }
    public required TournamentType Type { get; set; }
    public required TournamentTrainerDto Winner { get; set; }
    public required IList<TournamentTrainerDto> Trainers { get; set; }
}