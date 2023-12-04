using Library.Domain.Repositories.Enum;
using Library.Domain.Repositories.Interfaces;
using System.Text;

namespace Library.Domain.Repositories
{
    class Hero : Character, IAttacks, IWin, IBringBackToLife
    {
        public string Name { get; set; }
        public TypesOfHeroes Type { get; set; }
        public bool Died { get; set; }
        public double Mana { get; set; } 
        public double CriticalChance { get; set; }
        public double StunChance { get; set; } 

        public Hero(string name, double healthPoints, double damage)
        {
            Experience = 0;
            Name = name;
            HealthPoints = healthPoints;
            Damage = damage;
            Died = false;
            CriticalChance = 30;
            StunChance = 25;
            Mana = 40;
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
                StunChance += 7;
                CriticalChance += 8;
                Mana *= 1.1;
            }
        }
        public void Lost(Character character)
        {
            HealthPoints -= character.Damage;
        }

        public bool BringBackToLife()
        {
            if(Type != TypesOfHeroes.Enchater)
                return false;
            if (Died)
                return false;
            Died = true;
            HealthPoints = 30;
            return true;
        }
        //dodat ovo za heroja
        public void Rage()
        {
            HealthPoints *= 0.85;
        }
        public bool IsGladiator()
        { 
            if(Type == Enum.TypesOfHeroes.Gladiator)
                return true;
            return false;
        }
        public void Reset(Enum.TypesOfHeroes type, string name, double hp, double d)
        {
            Type= type;
            Name= name;
            HealthPoints = hp;
            Damage = d;
            Died = false;
        }
    }
}
