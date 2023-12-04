using Library.Domain.Repositories;
using Library.Domain.Repositories.All_Characters.Monsters;
using System.Text;

namespace Library.Domain
{
    public static class StartPlaying
    {
        public static StringBuilder sb = AllMonsters.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
        static Monster monster = AllMonsters.Monsters[0];
        static int number = monster.locationInDictionary;

        public static (bool?,bool) MakingMove(int actionKey)
        {
            monster = AllMonsters.Monsters[0];
            number = monster.locationInDictionary;
            var check = WhoWon(actionKey, number);
            if (check == null)
                return (false,false);
            if (check == true)
            {
                monster.Lost(AllMonsters.hero);
                AllMonsters.hero.Won(monster);
                if (monster.HealthPoints <= 0)
                {
                    if (AllMonsters.Monsters.Count > 0)
                        AllMonsters.Monsters.RemoveAt(0);
                    var isWitch = monster as Witch;
                    if (isWitch != null)
                    {
                        var list = new List<Monster>(){AllMonsters.GetMonster(), AllMonsters.GetMonster() };
                        list.AddRange(AllMonsters.Monsters);
                        AllMonsters.Monsters= list;                     
                    }
                    AllMonsters.hero.HealthPoints += 25;
                    if (AllMonsters.Monsters.Count==0)
                        return (true,true);
                }
                sb.Clear();
                sb = AllMonsters.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
                return (false, true);
            }
            else
            {
                AllMonsters.hero.Lost(monster);
                sb.Clear();
                sb = AllMonsters.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
                if (AllMonsters.hero.HealthPoints <= 0)
                    return (null,false);
            }
            return (false,false);
        }

        public static void IncreaseHealthPoints()
        {
            AllMonsters.hero.HealthPoints = 100;
            AllMonsters.hero.Experience /= 2;
        }
        public static bool? WhoWon(int num1, int num2)
        {
            if (num1 == 1 && num2 == 2)
                return true;
            if (num1 == 2 && num2 == 3)
                return true;
            if(num1 == 3 && num2 ==1)
                return true;
            if (num1 == num2)
                return null;
            return false;
        }
    }
}
