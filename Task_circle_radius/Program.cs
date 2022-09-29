// задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь
// округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади 
//круга.
//10 -> 4
//20 -> 7
//30 -> 8

Console.WriteLine("Введите радиус круга: ");

int R = Convert.ToInt32(Console.ReadLine());

const double PI = 3.1415926535897932384626433832795;

///double S = Math.Round(PI*Math.Pow(R,2));

int S = Convert.ToInt32(Math.Round(PI*Math.Pow(R,2)));
//Console.WriteLine( $" Площадь круга = {S}"); 


int max = 0;

while (S > 0)
  {
     if (max < S % 10) max = S % 10;
        S /= 10;
 }
 Console.WriteLine(max);
 Console.ReadKey();