using Library.Domain;
using Library.Domain.Repositories;

bool play;
do
{
    play = StartTheGame();
} while (play);

static bool StartTheGame()
{
    Console.WriteLine("Character name:");
    var name = Console.ReadLine();
    Console.WriteLine("If you want to define health points and damage yourself write yes, othervise you can choose which kind of hero you want to be.");
    var input = Console.ReadLine();
    if (input.Trim().ToLower() != "yes")
        ChooseCharacter(name);
    else
    {
        Console.WriteLine("Keep in mind that both health points and damage can't b over 60.\nHealth points: ");
        double hp, d;//hp as in health points, d as in damage
        double.TryParse(Console.ReadLine(), out hp);
        Console.WriteLine("Damage: ");
        double.TryParse(Console.ReadLine(), out d);
        Initialize.Default(hp, d, name);
    }
    Round();
    return true;
}

static void Round()
{
    Console.WriteLine(StartPlaying.sb);
    Console.WriteLine("Press the key corresponding to type of attack you want to make.\n\tdirect attack - D\n\tside attack - S\n\tcounter attack - C");
    var pressedKey = Console.ReadKey();
    int number = pressedKey.KeyChar switch
    {
        'D' => 1,
        'S' => 2,
        'C' => 3,
        _ => 0
    };
    if (number == 0)
    {
        Console.WriteLine("Incorrect input, try again");
        Round();
    }
    StartPlaying.Round(number);
}
static void ChooseCharacter(string name)
{
    Console.WriteLine("Choose one of the following:\n1. Gladiator\n2. Enchater\n3. Marksman");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);
    var success = Initialize.ChooseYourself(choice, name);
    if (!success)
        ChooseCharacter(name);
}



