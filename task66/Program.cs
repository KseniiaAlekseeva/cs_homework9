// Program finds the sum of natural numbers in range [M,N]

int SumInRange(int m, int n)
{
    if (m == n)
        return m;
    else
        return m + SumInRange(m + 1, n);
}

Console.Write("Enter the first natural number M: ");
int m = int.Parse(Console.ReadLine());
int n = m - 1;
while (n < m)
{
    Console.Write("Enter the second natural number N>=M: ");
    n = int.Parse(Console.ReadLine());
}

Console.WriteLine($"The sum of natural numbers in range [{m},{n}] is {SumInRange(m, n)}.");
