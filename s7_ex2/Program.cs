Console.Write("Введите количество строк в матрице     ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице  ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

Console.Write("Введите индекс строки i =  ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца j = ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число для поиска   ");
int number = Convert.ToInt32(Console.ReadLine());;

void FindNumberAndIndex(int[,] matr)
{
    int count = 0;
    int count1 = 0;
    if (i <= matr.GetLength(0) && j <= matr.GetLength(1))
    {
        Console.WriteLine($"Число под такими индексами равно {matr[i, j]}");
        count = count + 1;
    }
    if (count == 0) Console.WriteLine("Такого числа нет в данном массиве");

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                Console.WriteLine($"Данное число находится под индексами [{i},{j}]");
                count1 = count1 + 1;
            }
        }
    }
    if (count1 == 0) Console.WriteLine("Такого числа нет в данном массиве");
}

Console.WriteLine();
FindNumberAndIndex(matrix);
