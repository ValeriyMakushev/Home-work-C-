/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


double[,] array = FillArrayRandomNumbers(-1000,1000);
PrintArray(array);

double[,] FillArrayRandomNumbers( double min, double max)
{
    Console.WriteLine("Введите количество строк");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int colons = Convert.ToInt32(Console.ReadLine());

    double[,] numbers = new double[lines, colons];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round(new Random().NextDouble() * (max + 1 - min) + min,2);
        }
    }
    return numbers;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" [ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

