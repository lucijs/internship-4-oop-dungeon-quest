using Library.Domain.Repositories.All_Characters.Monsters;
namespace Library.Domain.Repositories
{
    static class AllMonsters
    {
        public static List<Monster> Monsters = new List<Monster>();


        public static Monster GetMonster()
        {
            var number = Help.RandomNumber();
            Monster monster;
            if (number < 75)
            {
                monster = new Goblin();
            }
            else if (number >= 75 && number < 85)
            {
                monster = new Witch();
            }
            else
            {
                monster = new Brute();
            }
            monster.locationInDictionary = number % 3 + 1;
            return monster;
        }

        public static void MonstersList()
        {
            for (int i = 0; i < 10; i++)
            {
                Monsters.Add(GetMonster());
            }
        }
    }
}
