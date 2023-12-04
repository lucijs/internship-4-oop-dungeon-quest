using Library.Domain.Repositories.Enum;
using Library.Domain.Repositories.Interfaces;
using System.Text;
namespace Library.Domain.Repositories
{
    class Monster : Character, IAttacks
    { 
        public TypesOfMonsters Type { get; set; }
        public int locationInDictionary { get; set; } = Help.RandomNumber() % 3 + 1;
        public Monster(int scale1, int scale2, int scale3)
        {
            HealthPoints = Help.RandomNumber(scale1);
            Damage = Help.RandomNumber(scale2);
            Experience = Help.RandomNumber(scale3);
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
    }
}
