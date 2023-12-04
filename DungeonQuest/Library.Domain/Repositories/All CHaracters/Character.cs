namespace Library.Domain.Repositories
{
    abstract class Character
    {
        public double HealthPoints { get; set; }

        public double Experience { get; set; } = 0;

        public double Damage { get; set; }
    }
}
