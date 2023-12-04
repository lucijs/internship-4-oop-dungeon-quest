namespace Library.Domain.Repositories
{
    public class Initialize
    {
        public static void HeroIsGladiator(string name)
        {
            Gladiator gladiator = new Gladiator(name);
        }

        public static void HeroIsEnchater(string name)
        {
            Enchater enchater = new Enchater(name);
            AllMonsters.GetMonster();
        }

        public static void HeroIsMarksman(string name)
        {
            Marksman marksman = new Marksman(name); 
        }
        
        public static bool Default(double hp, double d, string name)
        {
            if(d>60 && hp>60 &&hp>0 && d>0)
                return false;
            if (d > 60)
            {
                Enchater enchater = new Enchater(name, hp, d);
            }
            else if (hp > 60)
            {
                Gladiator gladiator = new Gladiator(name, hp, d);

            }
            else 
            {
                Marksman marksman = new Marksman(name, hp, d);

            }
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
