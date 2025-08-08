using FImonTournaments.Models.GameObjects.FImons.Abstracts;
using FImonTournaments.Utils;
using FImonTournaments.Utils.Constants;

namespace FImonTournaments.Models.GameObjects.Trainers
{
    public class Trainer
    {
        private static int nextId = 1;

        public int ID { get; }

        public string Name { get; }

        public FImon[] FImons { get; }

        public int FImonsAlive { get; set; }

        public int BattlesWon { get; set; }

        public int TotalBattles { get; set; }

        public int TournamentsWon { get; set; }

        public Trainer(FImon[] fimons, string name, int id = -1, int battlesWon = 0, int totalBattles = 0, int tournamentsWon = 0)
        {
            FImons = fimons;
            FImonsAlive = fimons.Length;
            Name = name;
            ID = id == -1 ? nextId++ : id;
            BattlesWon = battlesWon;
            TotalBattles = totalBattles;
            TournamentsWon = tournamentsWon;
        }

        public Trainer(string name, int fimonsAmount = TournamentConstants.FImonsPerTrainer) : this(Randomizer.GenerateRandomFImons(fimonsAmount), name) { }

        public static void SetStarterId(int id)
        {
            nextId = id;
        }

        public int HealFImons()
        {
            FImonsAlive = FImons.Length;

            foreach (FImon fimon in FImons)
            {
                fimon.CurrentHP = fimon.MaxHP;
            }
            return 0;
        }
    }
}