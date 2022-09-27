// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А Xa: ");
int Xa = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки А Ya: ");
int Ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A Za: ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B Xb: ");
int Xb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B Yb: ");
int Yb = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B Zb: ");
int Zb = int.Parse(Console.ReadLine());

double Ligth = Math.Sqrt((Math.Pow((Xb-Xa),2)+Math.Pow((Yb-Ya),2)+ Math.Pow((Zb-Za),2)));


Console.WriteLine ( "Длинна отрезка:" + Ligth );
