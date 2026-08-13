Console.Write("Enter a positive integer number: ");
int n = int.Parse(Console.ReadLine());

if (n <= 1)
    Console.WriteLine("Enter a positive integer number: ");

if (n == 2 || n == 3)
    Console.WriteLine($"{n} is a prime number.");

int nsqrt = (int)Math.Sqrt(n);

int i = 2;
while (i <= nsqrt)
{
    if (n % i == 0)
    {
        Console.WriteLine($"{n} is not a prime number.");
        break;
    }
    if (i == nsqrt && n % i != 0)
        Console.WriteLine($"{n} is a prime number.");
    i++;
}