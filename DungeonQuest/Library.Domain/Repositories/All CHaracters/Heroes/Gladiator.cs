namespace Library.Domain.Repositories
{
    internal class Gladiator : Hero
    {
        public Gladiator(string name):base (name) 
        {
            HealthPoints = 70;
            Damage = 30;
            Type = Enum.TypesOfHeroes.Gladiator;
        }
        public Gladiator(string name, double healthPoints, double damage) : base(name, healthPoints, damage)
        {
            Type = Enum.TypesOfHeroes.Gladiator;
        }
        public void Rage()
        {
            Damage *= 2;
            HealthPoints *= 0.85;
        }
    }
}
