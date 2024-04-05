using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighters.Models.Figters
{
    public class Figter : IFighter
    {
        public int MaxHealth = Race.Health;
        public int CurrentHealth { get; private set; }
        public string Name { get; }
        public IRace Race { get; }
        public IWeapon Weapon { get; private set;) } = new NoWeapon();
        public IArmor Armor { get; private set; } = new NoArmor();

        public Fighter
    }
}
