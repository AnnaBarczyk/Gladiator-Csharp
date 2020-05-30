using System.Runtime.CompilerServices;

namespace Gladiator.Gladiators
{
    public abstract class Gladiator
    {
        public int LVL;
        public float CurrentHealth { get; set; }
        protected string Name { get; private set; }
        private float HP;
        private float SP;
        private float DEX;
        private Multipliers _HPMultiplier;
        private Multipliers _SPMultiplier;
        private Multipliers _DEXMultiplier;

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

        protected Gladiator(int lvl, float hp, float sp, float dex, string name)
        {
            LVL = lvl;
            HP = hp;
            SP = sp;
            DEX = dex;
            Name = name;
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
        public float GetAvailableStaticticsHP()
        {

            float availableStatictics = HP * GetMultiplierValue(_HPMultiplier) * LVL;
            return availableStatictics;
        }
        
        public float GetAvailableStaticticsSP()
        {

            float availableStatictics = SP * GetMultiplierValue(_SPMultiplier) * LVL;
            return availableStatictics;
        }
        
        public float GetAvailableStaticticsDEX()
        {

            float availableStatictics = DEX * GetMultiplierValue(_DEXMultiplier) * LVL;
            return availableStatictics;
        }
}
}