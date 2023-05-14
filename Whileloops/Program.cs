
Random random = new Random();
int cpuRandom;

bool loopActive = true;

while(loopActive)
{
    cpuRandom =random.Next(1,4);
   // Console.WriteLine($"CPU has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter nurmber 1-3");

    int userNumber= Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congrats, You won!");
        //loopActive = false;
        break;
    } else
    {
        Console.WriteLine("You lose");
    }
}

Console.WriteLine("Have nice day!!");