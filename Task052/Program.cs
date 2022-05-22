// // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int m = 3, n = 3;
int[,] mass = new int[m, n];
int result = 0;
int[] summ = new int[m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        summ[i] = summ[i] + mass[j, i];
        result = summ[i] / m;
    }
    Console.Write(result + " ");
}
Console.WriteLine();
