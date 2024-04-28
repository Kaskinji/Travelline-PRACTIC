namespace Fighters.Models.Races
{
    public class Kadjite : IRace
    {
        public string Name => "Человек";
        public int Damage => 15;
        public int Health => 90;
        public int Armor => 10;
        public int Speed => 50;
    }
}