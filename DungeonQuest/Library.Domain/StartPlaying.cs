using Library.Domain.Repositories;
using System.Text;

namespace Library.Domain
{
    public static class StartPlaying
    {
        public static StringBuilder sb = AllMonsters.hero.NewPrint().Append(AllMonsters.Monsters[0].NewPrint());
        static Monster monster = AllMonsters.Monsters[0];
        static int number = monster.locationInDictionary;
        public static bool Round(int actionKey)
        {
            var check = WhoWon(actionKey, number);
            if (check == null)
                return false;
            if ((bool)check)
                AllMonsters.hero.Won(monster);

            return true;
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
