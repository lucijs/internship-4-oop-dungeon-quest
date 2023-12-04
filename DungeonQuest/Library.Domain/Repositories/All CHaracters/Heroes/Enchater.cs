namespace Library.Domain.Repositories
{
    internal class Enchater : Hero
    {
        public bool Died { get; set; }
        public double Mana { get; set; }//skužit kako mana funkcionira
        public Enchater(string name):base(name)
        {
            Damage = 70;
            HealthPoints = 30;
            Died = false;
            Type = Enum.TypesOfHeroes.Enchater;

        }

        public Enchater(string name,double healthPoints, double damage):base(name,healthPoints,damage)
        {
            Died = false;
            Type = Enum.TypesOfHeroes.Enchater;

        }
    }
}
