Console.WriteLine("Введите количество строк в матрице ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11) + Math.Round(rand.NextDouble(), 1);
        }
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
