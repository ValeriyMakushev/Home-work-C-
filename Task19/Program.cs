// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//void Task19()
//
    
Console.WriteLine("Input five-digit number: ");
string number = Console.ReadLine();

int Length  = number.Length;

if (Length == 5)
{
    if ( number[0] == number [4] && number[1] == number [3] )
    {
        Console.WriteLine ($" {number} - Палиндром");
    }
    else
    {
        Console.WriteLine ($" {number} - Не палиндром");
    }
}
else
{
Console.WriteLine ( $" Ошибка: {number} не является пятизначным");
}






//Console.WriteLine("Введите пятизначное число: ");

