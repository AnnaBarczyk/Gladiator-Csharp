namespace Gladiator.Gladiators
{
    public class Brutal : Gladiator
    {
        private Multipliers _HPMultiplier = Multipliers.High;
        private Multipliers _SPMultiplier = Multipliers.High;
        private Multipliers _DEXMultiplier = Multipliers.Low;
        
        public Brutal(int lvl, float hp, float sp, float dex, string name) : base(lvl, hp, sp, dex, name)
        {
        }
    }
}