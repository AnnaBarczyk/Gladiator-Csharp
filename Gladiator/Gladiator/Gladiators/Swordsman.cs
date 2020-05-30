namespace Gladiator.Gladiators
{
    public class Swordsman : Gladiator
    {
        private Multipliers _HPMultiplier = Multipliers.Medium;
        private Multipliers _SPMultiplier = Multipliers.Medium;
        private Multipliers _DEXMultiplier = Multipliers.Medium;
        
        public Swordsman(int lvl, float hp, float sp, float dex, string name) : base(lvl, hp, sp, dex, name)
        {
        }
    }
}