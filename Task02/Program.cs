// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {m} до {n} = {FindSumElements(m, n)}");

int FindSumElements(int min, int max)
{
    if (min == max) return min;
    else if (min < max) return min + FindSumElements(min + 1, max);
    else return max + FindSumElements(min, max + 1);
}

