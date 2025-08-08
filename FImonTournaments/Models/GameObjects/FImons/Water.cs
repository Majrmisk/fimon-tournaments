using FImonTournaments.Models.GameObjects.FImons.Abstracts;

namespace FImonTournaments.Models.GameObjects.FImons
{
    public class Water : FImon
    {
        public Water() : base() { }

        public Water(string name, int attack, int speed, int maxHP) : base(name, attack, speed, maxHP) { }

        public override int GetAttack(FImon opponent)
        {
            return opponent is Fire ? 2 * Attack : Attack;
        }
    }
}
