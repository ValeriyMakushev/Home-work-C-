// Задача 19 второй способ.

//Console.WriteLine("Введите пятизначное число: ");
//int num = Console.ReadLine();


void Task19()
{
        int num = CheckNumber();
        string chars = num.ToString();
        if (chars[0] == chars[4] && chars[1] == chars[3])
        {
                Console.Write("Число является палиндромом");
        }
        else
        {
                Console.Write("Число не является палиндромом");
        }
}

int CheckNumber()
{
        while (true)
        {
                Console.Write("Ведите пятизначное число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 9999 && number < 100000)
                        return number;
        }
}
Task19();



//Console.WriteLine("Hello, World!");
