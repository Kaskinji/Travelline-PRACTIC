using Fighters.Models.Armors;
using Fighters.Models.Types;
using Fighters.Models.Races;
using Fighters.Models.Weapons;
using Fighters.Models.Fighters;

namespace Fighters.Models.Fighters
{
    public class Fighter : IFighter
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public int CurrentHealth => (Race.Health + Class.Health);
        public string Name { get; }

        public IRace Race { get; }
        public IWeapon Weapon { get; private set; }
        public IArmor Armor { get; set; }
        public IType Class { get; private set; }

        public Fighter(string name, IRace race, IType newClass, IArmor newArmor, IWeapon newWeapon)
        {
 
            Name = name;
            Race = race;
            Class = newClass;
            Health = CurrentHealth;
            Weapon = newWeapon;
            Armor = newArmor;
        }

        public int CalculateDamage()
        {
            return Race.Damage + Weapon.Damage + Class.Damage;
        }

        public void TakeDamage(int damage)
        {
            int SetArmor = Armor.Armor;
            Health =- (damage - SetArmor);
            if (Health <= 0)
            {
                Health = 0;
            }
        }
        public bool IsDead()
        {
            if (Health <= 0) 
            {
                return(true);
            }
            else
            {
                return(false);
            }
        }
    }
}