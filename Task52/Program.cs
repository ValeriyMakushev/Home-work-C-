/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int colons = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[lines, colons];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0,100);
        }
    }
    PrintArray(numbers);
Console.WriteLine("---------------------------");
Console.WriteLine(numbers.GetLength(0));
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum += numbers[i, j];
    }
    Console.Write($"{Math.Round(sum / numbers.GetLength(0),2)} ");
}
Console.ReadLine();
void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write("  " + massiv[i, j] + " ");
        }
        Console.WriteLine("]");
    }
}


