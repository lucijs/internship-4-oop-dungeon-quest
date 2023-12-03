using Library.Domain.Repositories.Enum;
using System.Text;

namespace Library.Domain.Repositories
{
    class Hero : Character, IAttacks
    {
        public string Name { get; set; }
        public TypesOfHeroes Type { get; set; }
        public Hero()
        {
            Experience = 0;

        }
        public Hero(int healthPoints, int damage, string name)
        {
            HealthPoints = healthPoints;
            Damage = damage;
            Experience = 0;
            Name = name;
        }

        public StringBuilder Print()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name {Name}\n\t{Type}\n\tHeath Points {HealthPoints}\n\tExperience {Experience}\n\tDamage {Damage}");
            return sb;
        }

        public void DirectAttack()
        { }
        public void SideAttack()
        { }
        public void CounterAttack()
        { }
    }
}
