/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void Task29()
{
    Console.WriteLine( "Введите размер массива: ");
    int size = Convert.ToInt32( Console.ReadLine());
int[] array = new int[size];
FillArray(array);
PrintArray(array);
// int count = 0;
// Console.WriteLine ("[" String.Join(",", array)+ "]");
// if count = 0;
// for( int i=0; int<array.Length; int++)
// {
//     if(array[i] % 2== 0)
//     count++;
// }
// Console.WriteLine(count);
}

void FillArray(int[] arr )
{
    Random random = new Random();
    for( int i=0; i<arr.Length; i++)
    {
        arr[i] = random.Next(0,100);
    }
}
void PrintArray (int[] arr)
{
    for( int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] +" " );
    }
    Console.WriteLine();
}

Task29();