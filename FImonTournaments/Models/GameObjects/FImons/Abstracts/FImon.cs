using FImonTournaments.Utils;
using FImonTournaments.Utils.Constants;

namespace FImonTournaments.Models.GameObjects.FImons.Abstracts
{
    public abstract class FImon
    {
        public string Name { get; }
        public int Attack { get; protected set; }
        public int Speed { get; }
        public int MaxHP { get; private set; }
        public int CurrentHP { get; set; }

        public FImon(string name, int attack, int speed, int maxHP)
        {
            Name = name;
            Attack = attack;
            Speed = speed;
            MaxHP = maxHP;
            CurrentHP = maxHP;
        }

        public FImon()
        {
            Name = Randomizer.GetRandomFImonName();
            Attack = FImonConstants.BaseAttack + Randomizer.GetRandomNumber(-FImonConstants.StatsVariety, FImonConstants.StatsVariety);
            Speed = FImonConstants.BaseSpeed + Randomizer.GetRandomNumber(-FImonConstants.StatsVariety, FImonConstants.StatsVariety);
            MaxHP = FImonConstants.BaseHP - Attack - Speed;
            CurrentHP = MaxHP;
        }

        public abstract int GetAttack(FImon opponent);
    }
}
