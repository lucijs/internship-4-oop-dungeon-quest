namespace Library.Domain.Repositories
{
    public class Initialize
    {
        public static void HeroIsGladiator(string name)
        {
            AllMonsters.hero = new Gladiator(name);
            AllMonsters.MonstersList();
        }

        public static void HeroIsEnchater(string name)
        {
            AllMonsters.hero = new Enchater(name);
            AllMonsters.MonstersList();
        }

        public static void HeroIsMarksman(string name)
        {
            AllMonsters.hero = new Marksman(name);
            AllMonsters.MonstersList();
        }

        public static bool Default(double hp, double d, string name)
        {
            if(d>60 && hp>60 &&hp>0 && d>0)
                return false;
            if (d > 60)
                AllMonsters.hero = new Enchater(name, hp, d);
            else if (hp > 60)
                AllMonsters.hero = new Gladiator(name, hp, d);
            else
                AllMonsters.hero = new Marksman(name, hp, d);
            AllMonsters.MonstersList();
            return true;
        }

        public static bool ChooseYourself(int choice, string name)
        {
            switch (choice)
            {
                case 1:
                    HeroIsGladiator(name);
                    return true;
                case 2:
                    HeroIsEnchater(name);
                    return true;
                case 3:
                    HeroIsMarksman(name);
                    return true;
                default: 
                    return false;
            }
        }
    }
}
