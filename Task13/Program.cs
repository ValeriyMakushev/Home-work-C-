// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.WriteLine("Введите число: ");
//string number = Console.ReadLine();
//Console.WriteLine("Третья цифра: " + number.ToString()[2]);
//int a = number%10;
//Console.WriteLine($"Третье число:{a}");

//int number = new Random().Next(100,1000);
//Console.WriteLine("Число: "  + number);
//Console.WriteLine("Третья цифра: " + number.ToString()[2]);




    
//Console.Clear();
//Console.WriteLine("Введите число: ");

//int number = Convert.ToInt32(Console.ReadLine());
//string numberText = Convert.ToString(number);

//if (numberText.Lenght > 2)
      //  {
    //        Console.WriteLine("Третья цифра: " + numberText.ToString()[2]);
   //     }
//else
        //{
       //     Console.WriteLine("третьей цифры нет");
     //   }


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number.Length < 2)
{
    Console.WriteLine("Третья цифра: " + number.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
