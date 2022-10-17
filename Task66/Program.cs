/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30*/



 
 int PrintSumNumber(int M, int N)
 {
    if( N > M )
    return M + PrintSumNumber(M+1,N);
    else return M;


  
 }
int sum =  PrintSumNumber(1,15);
Console.WriteLine(sum);
