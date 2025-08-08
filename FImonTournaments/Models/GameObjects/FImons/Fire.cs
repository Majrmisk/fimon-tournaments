using FImonTournaments.Models.GameObjects.FImons.Abstracts;

namespace FImonTournaments.Models.GameObjects.FImons
{
    public class Fire : FImon
    {
        public Fire() : base() { }

        public Fire(string name, int attack, int speed, int maxHP) : base(name, attack, speed, maxHP) { }

        public override int GetAttack(FImon opponent)
        {
            return opponent is Leaf ? 2 * Attack : Attack;
        }
    }
}
