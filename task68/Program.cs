// Program calculating Akkerman function for two positive numbers M and N.

long Akkerman(long n, long m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.Write("Enter the first natural number N: ");
long n = long.Parse(Console.ReadLine());

Console.Write("Enter the second natural number M: ");
long m = long.Parse(Console.ReadLine());

Console.WriteLine($"Akkerman({n},{m}) is {Akkerman(n, m)}.");
