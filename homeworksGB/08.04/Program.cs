// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


// Console.WriteLine("Input number:  ");
// int num = Convert.ToInt32(Console.ReadLine());

//     if(num % 7 == 0 && num % 23 == 0)
//     {
//         System.Console.WriteLine("YES");
//     }
//     else
//     {
//         System.Console.WriteLine("NO");
//     }
 


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.Write("Input X:  ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y:  ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0)
// Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0)
// Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0)
// Console.WriteLine("Четвертая четверть");
// else
// Console.WriteLine($"Точка находится на {0}");



static void Main()
{
Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine(maxDigit);
}
