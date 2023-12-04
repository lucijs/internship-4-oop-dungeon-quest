using Library.Domain.Repositories.Enum;
using Library.Domain.Repositories.Interfaces;
using System.Text;
namespace Library.Domain.Repositories
{
    class Monster : Character, IAttacks
    { 
        public TypesOfMonsters Type { get; set; }
        public int locationInDictionary { get; set; } 
        public Monster(int scale1, int scale2, int scale3, int scale4)
        {
            HealthPoints = Help.RandomNumber(scale1)+scale4;
            Damage = Help.RandomNumber(scale2) + scale4;
            Experience = Help.RandomNumber(scale3) + scale4;
        }

        public StringBuilder NewPrint()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nmonster:\n\t{Type}");
            sb.Append(Print());
            return sb;
        }
        public void Won(Character character)
        {
        }

        public void Lost(Character character)
        {
            HealthPoints -= character.Damage;
        }
    }
}
