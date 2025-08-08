using FImonTournaments.Models.DTOs.TournamentHistoryDTOs;
using FImonTournaments.Models.DTOs.TrainersDTOs;

namespace FImonTournaments.Models.DTOs;

public class MainDataDto
{
    public IList<TournamentDto>? Tournaments { get; set; }

    public IList<TrainerDto>? Trainers { get; set; }
}
