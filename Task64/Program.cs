/* Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа 
в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8 */

PrintEvenNumber(0,10);

void PrintEvenNumber( int N, int M)
{
    if(N>M) return;
    if (N%2 == 0)
    
        {
            Console.WriteLine(N);
        }
        PrintEvenNumber(N+1, M);
}
