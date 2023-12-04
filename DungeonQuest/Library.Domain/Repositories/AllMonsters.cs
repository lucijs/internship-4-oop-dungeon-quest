using Library.Domain.Repositories.All_CHaracters.Monsters;
namespace Library.Domain.Repositories
{
    internal static class AllMonsters
    {
        public static Monster? GetMonster()
        {
            var number = Help.RandomNumber();
            Monster monster = number switch
            {
                < 60 => new Monster(),
                <90 => new Brute(),
                <100 => new Witch(),
                _ => null
            };
            return monster;
        }
    }
}
