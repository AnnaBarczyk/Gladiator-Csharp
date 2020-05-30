using System.Runtime.CompilerServices;

namespace Gladiator.Gladiators
{
    public abstract class Gladiator
    {
        public string Name { get; private set; }
        private int _HP;
        private int _SP;
        private int _DEX;
        private int _HPMultiplier;
        private int _SPMultiplier;
        private int _DEXMultiplier;
        
        public int LVL;
        
        public enum Multipliers
        {
            Low,
            Medium,
            High
        }

        public string GetFullName()
        {
            string classType = this.GetType().ToString();
            return classType + " " + Name;
        }

        private float GetMultiplierValue(Multipliers multipliers)
        {
            switch (multipliers)
            {
                case Multipliers.Low:
                    return 0.75f;
                case Multipliers.Medium:
                    return 1.00f;
                case Multipliers.High:
                    return 1.25f;
            }

            return 0;

        }
    }
}