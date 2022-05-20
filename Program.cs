int m = 3;
int n =4;
double[,] a = new double[m, n];

Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int k = 0; k < n; k++)
    {
        a[i, k] = random.NextDouble() * 100;
        Console.Write("{0,6:F2}", a[i, k]);
    }
    Console.WriteLine();
}