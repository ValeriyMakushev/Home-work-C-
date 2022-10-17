/* Задача 68: Задайте значения M и N. Напишите программу, которая найдёт 
наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7*/


int NODNumber(int M, int N)
{
if(M==0) return N;
  return NODNumber(N%M,M);
}
int NOD =  NODNumber(28,7);
Console.WriteLine(NOD);


// или вот так:
/*
int NODNumber(int M, int N)
{
if(M>N)
  return NODNumber(M%N,N);
  else return N;
}
int NOD =  NODNumber(125,30);
Console.WriteLine(NOD);
*/


