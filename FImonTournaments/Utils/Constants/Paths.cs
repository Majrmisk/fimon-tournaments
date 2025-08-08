namespace FImonTournaments.Utils.Constants;

public static class Paths
{
    public static readonly string DataFolder =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Data");

    public static readonly string GraphsFolder = Path.Combine(DataFolder, "Graphs");

    public static readonly string TournamentHistoryMain = Path.Combine(DataFolder, "Tournaments", "tournament_history.json");
    public static readonly string TrainersMain = Path.Combine(DataFolder, "Trainers", "trainers.json");
}
