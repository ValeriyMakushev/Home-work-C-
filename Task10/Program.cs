// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int randNum = new Random().Next(100, 1000); // 175
int a1 = randNum / 100; // 
int a2 = randNum % 10;
int midl = (randNum % 100 - a2) / 10;
int a3 = (a1 * 10) + a2;
Console.WriteLine(randNum);

Console.WriteLine($"Среднее число: {midl}");
