﻿using Library.Domain.Repositories;

bool first = true;
bool play;
do
{
    play = StartTheGame(first);
    first = false;
} while (play);

static bool StartTheGame(bool first)
{
    Console.Clear();
    Console.WriteLine("Character name:");
    var name = Console.ReadLine();
    Console.WriteLine("If you want to define health points and damage yourself write yes, othervise you can choose which kind of hero you want to be.");
    Console.WriteLine();
    var input = Console.ReadLine();
    if (input.Trim().ToLower() != "yes")
        ChooseCharacter(name, first);
    else
    {
        Console.WriteLine("Keep in mind that both health points and damage can't b over 60.\nHealth points: ");
        double hp, d;//hp as in health points, d as in damage
        double.TryParse(Console.ReadLine(), out hp);
        Console.WriteLine("Damage: ");
        double.TryParse(Console.ReadLine(), out d);
        Initialize.Default(hp, d, name, first);
    }
    bool? outcome1;
    bool outcome2;
    int roundCounter=1;
    do
    {
        (outcome1,outcome2) = Round();
        if (outcome2)
        {
            Console.Clear();
            Console.WriteLine($"That was the {roundCounter}. round and you won it.\nDo you want to use half of your Experience to renew your Health Points?");
            var choice = Console.ReadLine();
            if (choice.Trim().ToLower() != "yes")
                StartPlaying.IncreaseHealthPoints();
            roundCounter++;
        }
    } while (outcome1 == false);

    if (outcome1 == null)
    {
        Console.WriteLine("You lost. Do you want to play another game?");
        var choice = Console.ReadLine();
        if (choice.Trim().ToLower() != "yes")
            return false;
        return true;
    }
    Console.Clear();
    Console.WriteLine("\n\n\t\t\tCongratulations!\n\n\t\t\tYou won the game!");
    return false;
}
static (bool?,bool) Round()
{
    Console.Clear();
    StartPlaying.SetOutput();
    Console.WriteLine(StartPlaying.sb);
    bool activateRage=false;
    if (StartPlaying.RageAccessibility())
    {
        Console.WriteLine("If you want to use Rage (your danage doubles, however your health points lower for 15%) press r");
        var whatKey = Console.ReadKey();
        if (whatKey.KeyChar == 'r')
            activateRage = true;
    }
    Console.WriteLine("\nPress the key corresponding to type of attack you want to make.\n\tdirect attack - d\n\tside attack - s\n\tcounter attack - c");
    var pressedKey = Console.ReadKey();
    Console.ReadKey();
    int number = pressedKey.KeyChar switch
    {
        'd' => 1,
        's' => 2,
        'c' => 3,
        _ => 0
    };
    if (number == 0)
    {
        Console.WriteLine("Incorrect input, try again");
        Round();
    }
    return StartPlaying.MakingMove(number, activateRage);
}
static void ChooseCharacter(string name, bool first)
{
    Console.WriteLine("Choose one of the following:\n1. Gladiator\n2. Enchater\n3. Marksman");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);
    var success = Initialize.ChooseYourself(choice, name, first);
    if (!success)
        ChooseCharacter(name, first);
}



