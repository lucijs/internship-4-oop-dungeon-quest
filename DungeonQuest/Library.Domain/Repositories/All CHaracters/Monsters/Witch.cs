namespace Library.Domain.Repositories.All_Characters.Monsters
{
    class Witch: Monster
    {
        public Witch() : base(90,90,55,15) 
        {
            Type = Enum.TypesOfMonsters.Witch;
        }

        public int? Badlam()
        {
            var rand = Help.RandomNumber();
            if(rand%2==0)
                return null;
            return rand;
        }
    }
}
