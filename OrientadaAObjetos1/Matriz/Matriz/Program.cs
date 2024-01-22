// See https://aka.ms/new-console-template for more information
Console.Write("Numero de matriz de ordem: ");
int n =int.Parse(Console.ReadLine());

int[,] mat =new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < n;)
    {
        mat[i,j] = int.Parse(values[j]);
    }
}
Console.WriteLine("Main diagonal:");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine("Negative numbers: " + count);
