// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели");
int NumberDay = Convert.ToInt32(Console.ReadLine());
if (NumberDay <1|| NumberDay >7 )
{
    Console.WriteLine("Не является днем недели");
}
if (NumberDay ==1) {Console.WriteLine("Понедельник - рабочий день");}
if (NumberDay ==2) {Console.WriteLine("Вторник - рабочий день");}
if (NumberDay ==3) {Console.WriteLine("Среда - иди работай");}
if (NumberDay ==4) {Console.WriteLine("Четверг - , рабочий день,еще немного");}
if (NumberDay ==5) {Console.WriteLine("Пятница - ура пятница, но работать надо");}
if (NumberDay ==6) {Console.WriteLine("Суббота - выходной, Ура");}
if (NumberDay ==1) {Console.WriteLine("Воскресенье - выходной");}