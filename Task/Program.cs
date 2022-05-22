// // Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

double[,] mass = new double[3, 4];

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
        mass[i, j] = new Random().Next(-5, 5) + new Random().NextDouble();
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write("{0:0.00}", mass[i, j]);
    }
    Console.WriteLine();
}
