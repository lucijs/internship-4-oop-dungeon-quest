using Library.Domain.Repositories.Enum;
using Library.Domain.Repositories.Interfaces;
using System.Text;

namespace Library.Domain.Repositories
{
    class Hero : Character, IAttacks, IWin
    {
        public string Name { get; set; }
        public TypesOfHeroes Type { get; set; }
        public Hero(string name)
        {
            Experience = 0;
            Name = name;

        }
        public Hero(string name, double healthPoints, double damage)
        {
            Experience = 0;
            Name = name;
            HealthPoints = healthPoints;
            Damage = damage;
        }
        public StringBuilder NewPrint()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name {Name}\n\t{Type}");
            sb.Append(Print());
            return sb;
        }
        public void Won(Character character)
        {
            Experience += character.Experience;
            if (Experience >= 100)
            {
                HealthPoints += 15;
                Damage += 5;
                Experience %= 100;
            }
        }
        public void Lost(Character character)
        {
            HealthPoints -= character.Damage;
        }
    }
}
