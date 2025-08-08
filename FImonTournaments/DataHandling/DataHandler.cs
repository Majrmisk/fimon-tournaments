using FImonTournaments.Models.GameObjects.Tournaments;
using FImonTournaments.Utils.Constants;
using System.Text.Json;
using FImonTournaments.Models.GameObjects.Trainers;
using System.Text;
using FImonTournaments.Models.Helpers;
using FImonTournaments.Utils;
using FImonTournaments.DataHandling;

namespace FImonTournaments.Core;

public class DataHandler
{
    private static readonly JsonSerializerOptions options = new()
    {
        WriteIndented = true
    };

    private readonly IList<ArchivedTournament> _tournamentsHistory;
    private readonly IDictionary<int, Trainer> _trainers;

    private bool _changedTournaments = false;
    private bool _changedTrainers = false;

    private Task? _tournamentsSaving;
    private Task? _trainersSaving;

    private Task? _graphSaving;
    private IList<IList<BracketGraphTrainer>>? _graphLayers;
    private string? _graphName;

    public IList<ArchivedTournament> TournamentsHistory { get { return _tournamentsHistory.AsReadOnly(); } }
    public IDictionary<int, Trainer> Trainers { get { return _trainers.AsReadOnly(); } }

    public DataHandler()
    {
        var initialData = FileReader.GetSavedData();
        if (initialData.Tournaments == null || initialData.Trainers == null)
        {
            throw new InvalidDataException("[DATA READ ERROR] Failed to load initial data.");
        }

        _trainers = FileReader.ConvertTrainers(initialData.Trainers);
        _tournamentsHistory = FileReader.ConvertTournaments(initialData.Tournaments);
    }

    public async void ArchiveTournament(ArchivedTournament tournament)
    {
        if (_tournamentsSaving != null && !_tournamentsSaving.IsCompleted)
        {
            await _tournamentsSaving;
        }
        _changedTournaments = true;
        // Battle stats of trainers updated
        _changedTrainers = true;
        _tournamentsHistory.Add(tournament);
    }

    public async Task<bool> AddTrainer(Trainer trainer)
    {
        if (_trainersSaving != null && !_trainersSaving.IsCompleted)
        {
            await _trainersSaving;
        }
        _changedTrainers = true;
        return _trainers.TryAdd(trainer.ID, trainer);
    }

    public async Task<bool> RemoveTrainer(int trainerId)
    {
        if (_trainersSaving != null && !_trainersSaving.IsCompleted)
        {
            await _trainersSaving;
        }
        _changedTrainers = true;
        return _trainers.Remove(trainerId);
    }

    public async void SaveChanges()
    {

        if (_changedTournaments)
        {
            if (_tournamentsSaving != null && !_tournamentsSaving.IsCompleted)
            {
                await _tournamentsSaving;
            }
            
            _tournamentsSaving = SaveTournamentsAsync();
            _changedTournaments = false;
        }
        if (_changedTrainers)
        {
            if (_trainersSaving != null && !_trainersSaving.IsCompleted)
            {
                await _trainersSaving;
            }

            _trainersSaving = SaveTrainersAsync();
            _changedTrainers = false;
        }
        if (_graphLayers != null)
        {
            _graphSaving = CreateBracketGraph();
        }
    }

    public async Task ExitProgramCheckAsync()
    {
        if (_tournamentsSaving != null && !_tournamentsSaving.IsCompleted)
        {
            await _tournamentsSaving;
        }
        if (_trainersSaving != null && !_trainersSaving.IsCompleted)
        {
            await _trainersSaving;
        }
        if (_graphSaving != null && !_graphSaving.IsCompleted)
        {
            await _graphSaving;
        }
    }

    public async Task PrepareTrainersForGraph(IList<IList<Trainer>> trainerLayers, string name)
    {
        IList<IList<BracketGraphTrainer>> graphTrainerLayers = [];
        int index = 0;

        foreach (var trainerLayer in trainerLayers)
        {
            IList<BracketGraphTrainer> graphTrainerLayer = [];


            foreach (var trainer in trainerLayer)
            {
                graphTrainerLayer.Add(new BracketGraphTrainer(index++, trainer.Name, trainer.ID));
            }

            graphTrainerLayers.Add(graphTrainerLayer);
        }
        if (_graphSaving != null && !_graphSaving.IsCompleted)
        {
            await _graphSaving;
        }
        _graphLayers = graphTrainerLayers;
        _graphName = name;
    }

    private async Task SaveTournamentsAsync()
    {
        await using FileStream createStream = File.Create(Paths.TournamentHistoryMain);
        await JsonSerializer.SerializeAsync(createStream, DataUtils.ConvertTournamentsForDto(_tournamentsHistory), options);
    }

    private async Task SaveTrainersAsync()
    {
        await using FileStream createStream = File.Create(Paths.TrainersMain);
        await JsonSerializer.SerializeAsync(createStream, DataUtils.ConvertTrainersForDto(_trainers), options);
    }

    private async Task CreateBracketGraph()
    {
        if (_graphLayers == null || _graphName == null)
        {
            throw new NullReferenceException("[ERROR] Attempt to save a non-existent graph.");
        }

        StringBuilder graphBuilder = new();
        graphBuilder.AppendLine("digraph G {");

        foreach (var layer in _graphLayers)
        {
            foreach (var trainer in layer)
            {
                graphBuilder.AppendLine($"  {trainer.Index} [label=\"{trainer.ID}: {trainer.Name}\"];");
            }
        }

        for (int i = 0; i < _graphLayers.Count - 1; i++)
        {
            var currentLayer = _graphLayers[i];
            var nextLayer = _graphLayers[i + 1];

            for (int j = 0; j < currentLayer.Count / 2; j++)
            {
                int winnerIndex = nextLayer[j].Index;
                graphBuilder.AppendLine($"  {currentLayer[2 * j].Index} -> {winnerIndex};");
                graphBuilder.AppendLine($"  {currentLayer[2 * j + 1].Index} -> {winnerIndex};");
            }
        }

        graphBuilder.AppendLine("}");

        await File.WriteAllTextAsync(Path.Combine(Paths.GraphsFolder, $"{_graphName}.gv"), graphBuilder.ToString());
        _graphLayers = null;
        _graphName = null;
    }
}
