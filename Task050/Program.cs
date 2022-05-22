// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int m = 3, n = 3;
int[,] mass = new int[m, n];
Console.WriteLine("Введите первый индекс");
int a =int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй индекс");
int b = int.Parse(Console.ReadLine());

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

if (a < mass.GetLength(0))
{
    Console.WriteLine(mass[a,b]);
}
else
{
   Console.WriteLine("Элемента с таким индексом нет"); 
}