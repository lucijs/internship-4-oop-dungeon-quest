using Library.Domain.Repositories.All_Characters.Monsters;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Library.Domain.Repositories
{
    public static class StartPlaying
    {
        public static StringBuilder sb = Initialize.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
        static Monster monster;
        static int number;

        public static (bool?,bool) MakingMove(int actionKey, bool activateRage )
        {
            monster = AllMonsters.Monsters[0];
            number = monster.locationInDictionary;
            var check = WhoWon(actionKey, number);
            if (monster.LoseNextRound)
                check = true;
            if (check == null)
                return (false,false);
            if (check == true)
            {
                if (activateRage)
                {
                    Initialize.hero.Rage();
                    monster.Lost(Initialize.hero);
                }
                monster.Lost(Initialize.hero);
                Initialize.hero.Won(monster);
                if (Initialize.hero.Type == Enum.TypesOfHeroes.Enchater)
                { 
                    if(Initialize.hero.StunChance>49)
                        monster.Lost(Initialize.hero);
                    if (Initialize.hero.StunChance > 55)
                        monster.LoseNextRound = true;
                }
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
                    Initialize.hero.HealthPoints += 25;
                    if (AllMonsters.Monsters.Count == 0)
                        return (true, true);
                    sb.Clear();
                    sb = Initialize.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
                    return (false, true);
                }
                
            }
            else
            {
                var isWitch = monster as Witch;
                if (isWitch != null)
                {
                    int? num = isWitch.Badlam();
                    if (num != null)
                    {
                        foreach (var mon in AllMonsters.Monsters)
                        {
                            mon.HealthPoints = (int)num;
                        }
                        Initialize.hero.HealthPoints= (int)num;
                        return (false, false);
                    }
                }
                Initialize.hero.Lost(monster);
                if (Initialize.hero.HealthPoints <= 0)
                {
                    if (!Initialize.hero.BringBackToLife())
                    {
                        sb.Clear();
                        return (null, false);
                    }
                }
            }
            sb.Clear();
            sb = Initialize.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
            return (false,false);
        }

        public static void IncreaseHealthPoints()
        {
            Initialize.hero.HealthPoints = 100;
            Initialize.hero.Experience /= 2;
        }

        public static void SetOutput()
        {
            sb.Clear();
            sb = Initialize.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
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

        public static bool RageAccessibility()
        {
            return Initialize.hero.IsGladiator();
        }
    }
}