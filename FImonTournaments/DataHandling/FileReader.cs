using FImonTournaments.Models.DTOs;
using FImonTournaments.Models.DTOs.TournamentHistoryDTOs;
using FImonTournaments.Models.DTOs.TrainersDTOs;
using FImonTournaments.Models.GameObjects.FImons;
using FImonTournaments.Models.GameObjects.FImons.Abstracts;
using FImonTournaments.Models.GameObjects.Tournaments;
using FImonTournaments.Models.GameObjects.Trainers;
using FImonTournaments.Utils;
using FImonTournaments.Utils.Constants;
using System.Globalization;
using System.Text.Json;

namespace FImonTournaments.DataHandling;

public static class FileReader
{
    public static MainDataDto GetSavedData()
    {
        return new()
        {
            Tournaments = DeserializeTournamentHistory(Paths.TournamentHistoryMain),
            Trainers = DeserializeTrainers(Paths.TrainersMain)
        };
    }

    public static IList<ArchivedTournament> ConvertTournaments(IList<TournamentDto> tournaments)
    {
        IList<ArchivedTournament> archivedTournaments = [];

        foreach (TournamentDto tournamentDto in tournaments)
        {
            DateTime startDateTime;
            try
            {
                startDateTime = DateTime.ParseExact(tournamentDto.StartDateTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                throw new InvalidDataException("[TOURNAMENTS READING ERROR] Invalid tournament start datetime.");
            }

            if (!Enum.TryParse(tournamentDto.Type, out TournamentType type))
            {
                throw new InvalidDataException("[TOURNAMENTS READING ERROR] Invalid tournament type.");
            }

            ArchivedTournament archivedTournament = new()
            {
                Name = tournamentDto.Name,
                StartDateTime = startDateTime,
                Type = type,
                Winner = tournamentDto.Winner,
                Trainers = tournamentDto.Trainers
            };

            archivedTournaments.Add(archivedTournament);
        }

        return archivedTournaments;
    }

    public static Dictionary<int, Trainer> ConvertTrainers(IList<TrainerDto> trainersDto)
    {
        Dictionary<int, Trainer> trainers = [];
        var highestId = 0;
        foreach (TrainerDto trainerDto in trainersDto)
        {
            if (trainers.ContainsKey(trainerDto.ID))
            {
                throw new InvalidDataException("[TRAINERS READING ERROR] Duplicate trainer IDs");
            }
            highestId = trainerDto.ID > highestId ? trainerDto.ID : highestId;
            trainers.Add(trainerDto.ID, ConvertTrainer(trainerDto));
        }

        Trainer.SetStarterId(highestId + 1);

        return trainers;
    }

    private static Trainer ConvertTrainer(TrainerDto trainerDto)
    {
        var fimons = new FImon[trainerDto.FImons.Count];
        var i = 0;
        foreach (FImonDto fimonDto in trainerDto.FImons)
        {
            fimons[i++] = ConvertFImon(fimonDto);
        }
        return new(fimons, trainerDto.Name, trainerDto.ID, trainerDto.BattlesWon, trainerDto.TotalBattles, trainerDto.TournamentsWon);
    }

    private static FImon ConvertFImon(FImonDto fimonDto)
    {
        return fimonDto.Type switch
        {
            "Fire" => new Fire(fimonDto.Name, fimonDto.Attack, fimonDto.Speed, fimonDto.HP),
            "Water" => new Water(fimonDto.Name, fimonDto.Attack, fimonDto.Speed, fimonDto.HP),
            "Leaf" => new Leaf(fimonDto.Name, fimonDto.Attack, fimonDto.Speed, fimonDto.HP),
            _ => throw new InvalidDataException("[TRAINERS READING ERROR] Invalid FImon type."),
        };
    }

    private static IList<TournamentDto>? DeserializeTournamentHistory(string filePath)
    {
        var jsonString = ReadFile(filePath);
        return jsonString == null ? [] : JsonSerializer.Deserialize<IList<TournamentDto>>(jsonString);
    }

    private static IList<TrainerDto>? DeserializeTrainers(string filePath)
    {
        var jsonString = ReadFile(filePath);
        return jsonString == null ? [] : JsonSerializer.Deserialize<IList<TrainerDto>>(jsonString);
    }

    private static string? ReadFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return null;
        }
        var jsonString = File.ReadAllText(filePath);
        if (string.IsNullOrWhiteSpace(jsonString))
        {
            return null;
        }
        return jsonString;
    }
}
