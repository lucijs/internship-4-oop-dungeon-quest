﻿namespace Library.Domain.Repositories.All_Characters.Monsters
{
    class Goblin : Monster
    {
        public Goblin() : base(30,30,8)
        {
            Type = Enum.TypesOfMonsters.Goblin;
        }
    }
}
