/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
425 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum=0;
int temp;
for (int i=0; i<number; i++ )
{
temp = number - number % 10;
//Console.WriteLine( temp);
sum = sum+(number- temp);
number = number/10;
}

Console.WriteLine( "Сумма чисел равна: " + sum);

