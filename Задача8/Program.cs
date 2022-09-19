// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool not = true;
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ( " Чётные числа от 1 до "  +  x );

while (i <= x)
{
    if (i % 2 !=1) 
    {
    Console.Write (i + ",");
    not = false;
    }
    i=i+1;
}
if (not)
{
   Console.WriteLine ( " Нет чётных чисел! " );
}