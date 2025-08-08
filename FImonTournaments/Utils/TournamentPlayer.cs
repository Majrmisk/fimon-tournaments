using FImonTournaments.Core;
using FImonTournaments.Models.DTOs.TournamentHistoryDTOs;
using FImonTournaments.Models.GameObjects.FImons.Abstracts;
using FImonTournaments.Models.GameObjects.Tournaments;
using FImonTournaments.Models.GameObjects.Trainers;

namespace FImonTournaments.Utils;

public class TournamentPlayer(Tournament _tournament, ListBox _tournamentsListBox, DataHandler _dataHandler)
{
    public void Play()
    {
        Trainer winner;
        if (_tournament.Type == TournamentType.Standard)
        {
            winner = PlayStandardTournament(_tournament.Trainers);
        }
        else if (_tournament.Type == TournamentType.Groups)
        {
            winner = PlayGroupsTournament(_tournament.Trainers);
        }
        else
        {
            throw new InvalidOperationException("[ERROR] Use of not implemented TournamentType.");
        }
        winner.TournamentsWon++;
        _dataHandler.ArchiveTournament(new()
        {
            Name = _tournament.Name,
            StartDateTime = _tournament.StartTime,
            Type = _tournament.Type,
            Winner = new(winner.Name, winner.ID.ToString()),
            Trainers = _tournament.Trainers
                .Select(trainer => new TournamentTrainerDto(trainer.Name, trainer.ID.ToString()))
                .ToList()
        });
    }

    private Trainer PlayStandardTournament(IList<Trainer> trainers)
    {
        IList<IList<Trainer>> trainerLayers = [trainers];

        var layer = 0;
        while (trainerLayers[layer].Count > 1)
        {
            trainerLayers.Add([]);
            int i = 0;

            _tournamentsListBox.Items.Add("");
            _tournamentsListBox.Items.Add($"---------Round {layer + 1} - {trainerLayers[layer].Count} Trainers Remaining---------");

            while (i < trainerLayers[layer].Count - 1)
            {
                var trainerOne = trainerLayers[layer][i++];
                var trainerTwo = trainerLayers[layer][i++];

                trainerLayers[layer + 1].Add(Fight(trainerOne, trainerTwo));
                trainerOne.HealFImons();
                trainerTwo.HealFImons();
            }
            layer++;
        }

        var winner = trainerLayers[^1][0];
        _tournamentsListBox.Items.Add("");
        _tournamentsListBox.Items.Add($"---------Tournament over! - Winner - {winner.Name} ({winner.ID})---------");
        _tournamentsListBox.Items.Add("");

        // The graph structure creation is synchronous, but the export into a file is async.
        _ = _dataHandler.PrepareTrainersForGraph(trainerLayers, _tournament.Name);
        return winner;
    }

    private Trainer PlayGroupsTournament(IList<Trainer> trainers)
    {
        var sizeOfGroup = trainers.Count / 2;
        var groupOneIndex = sizeOfGroup - 1;
        var groupTwoIndex = trainers.Count - 1;
        var round = 1;

        while (groupOneIndex >= 0 && groupTwoIndex > sizeOfGroup - 1)
        {
            _tournamentsListBox.Items.Add("");
            _tournamentsListBox.Items.Add($"---------Round {round++} - Group One - {groupOneIndex + 1} --- Group Two - {groupTwoIndex - sizeOfGroup + 1} Trainers Left---------");

            var trainerOne = trainers[groupOneIndex];
            var trainerTwo = trainers[groupTwoIndex];

            if (Fight(trainerOne, trainerTwo).ID == trainerOne.ID)
            {
                groupTwoIndex--;
                trainerTwo.HealFImons();
            }
            else
            {
                groupOneIndex--;
                trainerOne.HealFImons();
            }
        }

        var winner = groupOneIndex > 0 ? trainers[groupOneIndex] : trainers[groupTwoIndex];
        winner.HealFImons();

        var winnerGroup = groupOneIndex > 0 ? "One" : "Two";
        _tournamentsListBox.Items.Add("");
        _tournamentsListBox.Items.Add($"---------Tournament over! - Winner - Group {winnerGroup}---------");

        return winner;
    }

    private Trainer Fight(Trainer trainerOne, Trainer trainerTwo)
    {
        _tournamentsListBox.Items.Add("");
        _tournamentsListBox.Items.Add($"----[TRAINERS] {trainerOne.Name} vs {trainerTwo.Name}----");

        var trainerOneIndex = 0;
        var trainerTwoIndex = 0;
        var round = 1;

        while (trainerOne.FImonsAlive > 0 && trainerTwo.FImonsAlive > 0)
        {
            round++;
            if (Round(trainerOne.FImons[trainerOneIndex], trainerTwo.FImons[trainerTwoIndex]).Equals(trainerOne.FImons[trainerOneIndex]))
            {
                trainerTwoIndex++;
                trainerTwo.FImonsAlive--;
            }
            else
            {
                trainerOneIndex++;
                trainerOne.FImonsAlive--;
            }
        }

        var winner = trainerOne.FImonsAlive > 0 ? trainerOne : trainerTwo;

        winner.BattlesWon++;
        trainerOne.TotalBattles++;
        trainerTwo.TotalBattles++;

        _tournamentsListBox.Items.Add($"----[TRAINERS] Winner - {winner.Name}----");
        return winner;
    }

    private FImon Round(FImon fimonOne, FImon fimonTwo)
    {

        var oneDamage = fimonOne.GetAttack(fimonTwo);
        var twoDamage = fimonTwo.GetAttack(fimonOne);
        var playersTurn = fimonOne.Speed >= fimonTwo.Speed;

        while (fimonOne.CurrentHP > 0 && fimonTwo.CurrentHP > 0)
        {
            if (playersTurn)
            {
                fimonTwo.CurrentHP -= oneDamage;
            }
            else
            {
                fimonOne.CurrentHP -= twoDamage;
            }
            playersTurn = !playersTurn;
        }

        var winner = fimonOne.CurrentHP > 0 ? fimonOne : fimonTwo;
        _tournamentsListBox.Items.Add($"[FIMONS] {fimonOne.Name} vs {fimonTwo.Name} - {winner.Name} Wins!");
        return winner;
    }
}