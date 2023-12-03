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

    Console.WriteLine("If you want to define health points and damage yourself write yes, othervise you csn choose which kind of hero you want to be.");
    var input = Console.ReadLine();
    if (input.Trim().ToLower() != "yes")
        ChooseCharacter();
    return true;
}

static void ChooseCharacter()
{
    Console.WriteLine("Choose one of the following:\n1. Gladiator\n2. Enchater\n3. Marksman");
    int choice;
    int.TryParse(Console.ReadLine(), out choice);
    var success = Initialize.ChooseYourself(choice);
    if (!success)
        ChooseCharacter();
}



Console.WriteLine("nesto");
