namespace Library.Domain.Repositories
{
    public class Initialize
    {
        public static Dictionary<int, Action> AllTypes = new Dictionary<int, Action>()
        {
            {1, HeroIsGladiator },
            {2, HeroIsEnchater},
            {3, HeroIsMarksman }
        };

        public static void HeroIsGladiator()
        {
            Gladiator gladiator = new Gladiator();
        }

        public static void HeroIsEnchater()
        {

        }

        public static void HeroIsMarksman()
        {

        }

        public static void Default()
        {

        }

        public static bool ChooseYourself(int choice)
        {
            Console.WriteLine(choice);
            foreach (var option in AllTypes)
            {
                if (choice == option.Key)
                {
                    option.Value.Invoke();
                    return true;
                }
            }
            return false;
        }
    }
}
