using System.Text;

namespace Library.Domain.Repositories
{
    abstract class Character
    {
        public double HealthPoints { get; set; }
        public double Experience { get; set; } = 0;
        public double Damage { get; set; }
        public StringBuilder Print()
        {
            var sb = new StringBuilder();
            sb.Append($"\n\tHeath Points {HealthPoints}\n\tExperience {Experience}\n\tDamage {Damage}");
            return sb;
        }
    }
}
