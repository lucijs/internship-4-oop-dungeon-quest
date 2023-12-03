namespace Library.Domain.Repositories
{
    abstract class Monster : Character
    {
        public Dictionary<int, Action> Actions = new Dictionary<int, Action>()
        {
            {1, DirectAttack},
            {2, SideAttack},
            {3, CounterAttack}

        };
        public static void DirectAttack()
        {

        }
        public static void SideAttack()
        { }
        public static void CounterAttack()
        { }
    }
}
