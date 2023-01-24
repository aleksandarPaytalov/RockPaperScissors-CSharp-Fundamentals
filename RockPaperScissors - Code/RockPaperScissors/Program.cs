const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "Rock")
{
    playerMove = "Rock";
}
else if (playerMove == "p" || playerMove == "Paper")
{
    playerMove = "Paper";
}
else if (playerMove == "s" || playerMove == "Scissors")
{
    playerMove = "Scissors";
}
else
{
    Console.WriteLine("Invalid Input. Try Again...");
    return;
}
Random random = new Random();
int computerRandomNumber = random.Next(1, 4);
string computerMove = "";

switch (computerRandomNumber)
{
    case 1:
        computerMove = rock;
        break;
    case 2:
        computerMove = paper;
        break;
    case 3:
        computerMove = scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}");
if (playerMove == rock && computerMove == scissors || playerMove == paper && computerMove == rock || playerMove == scissors && computerMove == paper)
{
    Console.WriteLine("You win.");
}
else if (playerMove == rock && computerMove == paper || playerMove == paper && computerMove == scissors || playerMove == scissors && computerMove == rock)
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}