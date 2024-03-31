namespace Fighters.models
    public interface IFigther
    {
        public int MaxHealth { get }
        public int CurrentHealth { get }
        public int Power { get }
        public IArmor Armor { get }
        public int CalculateDamage { get }
}