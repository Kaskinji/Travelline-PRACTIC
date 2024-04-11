using Fighters.Models.Armors;
using Fighters.Models.Classes;
using Fighters.Models.Races;
using Fighters.Models.Weapons;

namespace Fighters.Models.Fighters
{
    public class Fighter : IFighter
    {
        public int MaxHealth => (Race.Health + Class.Health);
        public int CurrentHealth { get; set; }

        public string Name { get; }

        public IRace Race { get; }
        public IWeapon Weapon { get; set; }
        public IArmor Armor { get;  set; }
        public IClass Class { get; set; }

        public Fighter(string name, IRace race, IClass newClass, IArmor newArmor, IWeapon newWeapon)
        {
 
            Name = name;
            Race = race;
            Class = newClass;
            CurrentHealth = MaxHealth;
            Weapon = newWeapon;
            Armor = newArmor;
        }

        public int CalculateDamage()
        {
            return Race.Damage + Weapon.Damage + Class.Damage;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
    }
}