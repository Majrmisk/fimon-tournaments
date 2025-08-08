namespace FImonTournaments.Utils.Constants;

public static class TournamentConstants
{
    public static readonly Dictionary<TournamentSize, int> TournamentSizeTrainerAmount = new()
    {
        { TournamentSize.Small, 4 },
        { TournamentSize.Medium, 8 },
        { TournamentSize.Large, 16 }
    };

    // Can be adjusted.
    public const int FImonsPerTrainer = 3;
}
