/*** Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */
Console.Clear();
Console.WriteLine("Введите число, не больше 7, обозначающее день недели");
int n = int.Parse(Console.ReadLine());
while (n > 7)
{
Console.WriteLine("Попробуйте ещёт раз, ведите число, не больше 7, обозначающее день недели");
int s = int.Parse(Console.ReadLine());
n = s ;}
if (n == 7 || n == 6)
{Console.WriteLine("да");}
else
{Console.WriteLine("нет");}