int randomNumber = Random.Shared.Next(1, 101); 

for (int i = 1; i <= 100; i++)
{
    Console.Write("Guess the number (1-100):");
    int n = int.Parse(Console.ReadLine());
    if (n > randomNumber)
        Console.WriteLine($"Guess a smaller number than {n}: ");
    else if (n < randomNumber)
        Console.WriteLine($"Guess a greater number than {n}: ");
    else
    {
        Console.WriteLine($"Correct! The number is {n}. It took you {i} guesses.");
        break;
    }
}