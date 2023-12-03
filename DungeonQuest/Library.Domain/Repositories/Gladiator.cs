namespace Library.Domain.Repositories
{
    internal class Gladiator : Hero
    {
        public Gladiator()
        {
            HealthPoints = 70;
            Damage = 30;
            Type = Enum.TypesOfHeroes.Gladiator;
        }

        public void Rage()
        {
            Damage *= 2;
            HealthPoints *= 0.85;
        }
    }
}
