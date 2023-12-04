using System.ComponentModel.Design;

namespace Library.Domain.Repositories
{
    public  class Initialize
    {
        internal static Hero hero;
        public static void HeroIsGladiator(string name,bool first)
        {
            hero = new Hero(name, 70, 30);
            hero.Type = Enum.TypesOfHeroes.Gladiator;
            AllMonsters.MonstersList();
        }

        public static void HeroIsEnchater(string name, bool first)
        {
            hero = new Hero(name, 50, 50);
            hero.Type = Enum.TypesOfHeroes.Enchater;
            AllMonsters.MonstersList();
        }

        public static void HeroIsMarksman(string name, bool first)
        {
            hero = new Hero(name, 30, 70);
            hero.Type = Enum.TypesOfHeroes.Marksman;
            AllMonsters.MonstersList();
        }

        public static bool Default(double hp, double d, string name, bool first)
        {
            if(d>60 && hp>60 &&hp>0 && d>0)
                return false;
            if (d > 60)
            {
                if (!first)
                    hero.Reset(Enum.TypesOfHeroes.Enchater, name, hp, d);
                else
                {
                    hero = new Hero(name, hp, d);
                    hero.Type = Enum.TypesOfHeroes.Enchater;
                }
            }
            else if (hp > 60)
            {
                if (!first)
                    hero.Reset(Enum.TypesOfHeroes.Gladiator, name, hp, d);
                else
                {
                    hero = new Hero(name, hp, d);
                    hero.Type = Enum.TypesOfHeroes.Gladiator;
                }
            }
            else
            {
                if (!first)
                    hero.Reset(Enum.TypesOfHeroes.Marksman, name, hp, d);
                else
                {
                    hero = new Hero(name, hp, d);
                    hero.Type = Enum.TypesOfHeroes.Marksman;
                }
            }
            AllMonsters.MonstersList();
            return true;
        }

        public static bool ChooseYourself(int choice, string name, bool first)
        {
            switch (choice)
            {
                case 1:
                    if(!first)
                        hero.Reset(Enum.TypesOfHeroes.Gladiator, name, 70, 30);
                    else
                        HeroIsGladiator(name, first);
                    return true;
                case 2:
                    if(!first)
                        hero.Reset(Enum.TypesOfHeroes.Enchater, name, 50, 50);
                    else
                        HeroIsEnchater(name, first);
                    return true;
                case 3:
                    if(!first)
                        hero.Reset(Enum.TypesOfHeroes.Marksman, name, 30, 70);
                    else
                        HeroIsMarksman(name, first);
                    return true;
                default: 
                    return false;
            }
        }
    }
}
