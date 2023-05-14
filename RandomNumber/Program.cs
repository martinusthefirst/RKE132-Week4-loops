Random random = new Random();
int myRandomNum;
int randomSum =0;

for(int i = 0; i < 3; i++)
{
     myRandomNum = random.Next (0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine ($"My Random Number is: {myRandomNum}");

}

Console.WriteLine ($"Random sum total:{randomSum}");