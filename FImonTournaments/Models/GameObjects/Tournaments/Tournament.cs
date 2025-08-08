using FImonTournaments.Models.GameObjects.Trainers;
using FImonTournaments.Utils;

namespace FImonTournaments.Models.GameObjects.Tournaments;

public class Tournament
{
    public DateTime StartTime { get; } = DateTime.Now;

    public string Name { get; }

    public IList<Trainer> Trainers { get; }

    public TournamentSize Size { get; }

    public TournamentType Type { get; }

    public Tournament(IList<Trainer> trainers, string name, TournamentSize size, TournamentType type)
    {
        Name = name;
        Size = size;
        Trainers = trainers;
        Type = type;
    }
}
