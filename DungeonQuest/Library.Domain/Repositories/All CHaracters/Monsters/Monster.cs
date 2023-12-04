using Library.Domain.Repositories.Enum;
using System.Security.Cryptography;

namespace Library.Domain.Repositories
{
    class Monster : Character
    {
        //we will be using it as goblin and it will be a parent class to brutes and witches 
        public TypesOfMonsters Type { get; set; } = TypesOfMonsters.Goblin;

        public Monster()
        {
            HealthPoints = Help.RandomNumber(30);
            Damage = Help.RandomNumber(30);
            Experience = Help.RandomNumber(8);
            Console.WriteLine($"{HealthPoints} - {Experience} - {Damage}");
        }

        public static void DirectAttack()
        { }
        public static void SideAttack()
        { }
        public static void CounterAttack()
        { }
    }
}
