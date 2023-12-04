namespace Library.Domain.Repositories.All_Characters.Monsters
{
    class Brute : Monster
    {
        //može oduzet igraču postotak života umisto fiksan br
        public Brute():base(75,60,25,10)
        {
            Type = Enum.TypesOfMonsters.Brute;
        }
    }
}
