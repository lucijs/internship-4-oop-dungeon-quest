namespace Library.Domain.Repositories
{
    internal class Marksman : Hero
    {
        public double CriticalChance { get; set; }
        public double StunChance { get; set; }
        public Marksman(string name):base(name)
        {
            Damage = 50;
            HealthPoints = 50;
            CriticalChance = 7;
            StunChance = 7;
            Type = Enum.TypesOfHeroes.Marksman;
        }
        public Marksman(string name, double healthPoints, double damage):base(name,healthPoints,damage)
        {
            CriticalChance = 7;
            StunChance = 7;
            Type = Enum.TypesOfHeroes.Marksman;

        }
    }
}
