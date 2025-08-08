using FImonTournaments.Models.GameObjects.FImons.Abstracts;

namespace FImonTournaments.Models.GameObjects.FImons
{
    public class Leaf : FImon
    {
        public Leaf() : base() { }

        public Leaf(string name, int attack, int speed, int maxHP) : base(name, attack, speed, maxHP) { }

        public override int GetAttack(FImon opponent)
        {
            return opponent is Water ? 2 * Attack : Attack;
        }
    }
}
