string userPIN;
int triesUsed = 0;
while (triesUsed
userPIN
  3) 
{
    Console.WriteLine("Enter your PIN");
    userPIN = Console.ReadLine();
    if (
userPIN
  == "1234")
    {
        Console.WriteLine("Welcome!");
        triesUsed = 3; //number
    }

    userPIN


    {
        Console.WriteLine($"Wrong PIN. Try again. {3 - triesUsed} tries left.");


!=
 ++;
    }
}