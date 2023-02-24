// Program outputs all natural numbers from N to 1

void PrintNumbers(int n)
{
    Console.Write(n + ", ");
    if (n == 1)
        return;
    else
        PrintNumbers(n - 1);
}


Console.Write("Enter the natural number N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n);

