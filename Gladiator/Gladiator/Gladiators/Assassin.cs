namespace Gladiator.Gladiators
{
    public class Assassin : Gladiator
    {
        private Multipliers _HPMultiplier = Multipliers.Low;
        private Multipliers _SPMultiplier = Multipliers.High;
        private Multipliers _DEXMultiplier = Multipliers.High;
        
        public Assassin(int lvl, float hp, float sp, float dex, string name) : base(lvl, hp, sp, dex, name)
        {
        }
    }
}