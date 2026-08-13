Console.Write("Enter a positive integer number: ");
int n = int.Parse(Console.ReadLine());

if (n <= 1)
    Console.WriteLine($"{n} is not a prime number.");

if (n > 1)
{
    Console.Write("2 ");
    for (int i = 3; i < n; i++)
    {
        bool prime = true;
        for (int j = 2; j < n; j++)
        {
            if (i % j == 0)
                prime = false;
                break;
        }
        if (prime)
            Console.Write(i + " ");
    }
}