namespace Library.Domain.Repositories.All_Characters.Monsters
{
    class Witch: Monster
    {
        //kad je dobijes stavar dva nova čudovišta
        //ima posebnu moč đumbus da kad dobije postavi svima hp na neku sluč vrijednost
        public Witch() : base(90,90,55,15) 
        {
            Type = Enum.TypesOfMonsters.Witch;
        }
    }
}
