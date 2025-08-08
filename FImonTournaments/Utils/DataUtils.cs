using FImonTournaments.Models.DTOs.TournamentHistoryDTOs;
using FImonTournaments.Models.DTOs.TrainersDTOs;
using FImonTournaments.Models.GameObjects.FImons.Abstracts;
using FImonTournaments.Models.GameObjects.FImons;
using FImonTournaments.Models.GameObjects.Tournaments;
using FImonTournaments.Models.GameObjects.Trainers;

namespace FImonTournaments.Utils;

public static class DataUtils
{
    public static IList<TournamentDto> ConvertTournamentsForDto(IList<ArchivedTournament> tournaments)
    {
        return tournaments.Select(tournament => new TournamentDto
        {
            Name = tournament.Name,
            StartDateTime = tournament.StartDateTime.ToString("yyyy-MM-dd HH:mm"),
            Type = tournament.Type.ToString(),
            Winner = tournament.Winner,
            Trainers = [.. tournament.Trainers]
        }).ToList();
    }

    public static IList<TrainerDto> ConvertTrainersForDto(IDictionary<int, Trainer> trainers)
    {
        return trainers
            .OrderBy(kvp => kvp.Key)
            .Select(kvp => new TrainerDto
            {
                ID = kvp.Key,
                Name = kvp.Value.Name,
                BattlesWon = kvp.Value.BattlesWon,
                TotalBattles = kvp.Value.TotalBattles,
                TournamentsWon = kvp.Value.TournamentsWon,
                FImons = kvp.Value.FImons.Select(fimon => ConvertFImonToDto(fimon)).ToList()
            })
            .ToList();
    }

    private static FImonDto ConvertFImonToDto(FImon fimon)
    {
        return new FImonDto
        {
            Name = fimon.Name,
            Attack = fimon.Attack,
            Speed = fimon.Speed,
            HP = fimon.MaxHP,
            Type = GetFImonType(fimon)
        };
    }

    private static string GetFImonType(FImon fimon)
    {
        if (fimon is Fire)
        {
            return "Fire";
        }
        else if (fimon is Leaf)
        {
            return "Leaf";
        }
        else if (fimon is Water)
        {
            return "Water";
        }
        else
        {
            throw new InvalidOperationException("[ERROR] Use of not implemented FImon type.");
        }
    }
}