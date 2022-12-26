// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт 
// наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

Console.Clear();
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindNum(m, n));

int FindNum(int a, int b)
{
    if (b == 0) return a;
    else return FindNum(b, a % b);
}