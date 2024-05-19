// ﻿// Задача 1: Напишите программу, которая бесконечно 
// // запрашивает целые числа с консоли. Программа завершается
// // при вводе символа ‘q’ или при вводе числа,
// // сумма цифр которого чётная.

// using System;
// class Program
// {
//     static void Main()
//     {
//         bool InputNum()
//         {
//             System.Console.WriteLine("Введите любое целое число сумма цифр которого чётная или 'q' для выхода: ");
//             string input = System.Console.ReadLine();

//             if (input == "q")
//             {
//                 System.Console.WriteLine($"Вы ввели букву 'q'. До свидания! ");
//                 return false;
//             }

//             else
//             {
//                 if (int.TryParse(input, out int number))
//                 {
//                     int num = Convert.ToInt32(input);
//                     if (num > 0)
//                     {
//                         int sum = 0;
//                         while (num > 0)
//                         {
//                             sum = sum + num % 10;
//                             num = num / 10;
//                         }

//                         num = Convert.ToInt32(input);

//                         if (sum % 2 == 0)
//                         {
//                             System.Console.WriteLine($"Вы ввели число {num}, сумма цифр которого равна {sum} - это четное число. До свидания!");
//                             return false;
//                         }
//                         System.Console.WriteLine($"Вы ввели число {num}, сумма цифр которого равна {sum} - это нечетное число.");
//                         return true;
//                     }
//                     else
//                     {
//                         System.Console.WriteLine($"Вы ввели число {num}. Число должно быть положительным.");
//                         return true;
//                     }
//                 }

//             }

//             System.Console.WriteLine($"Вы ввели: {input}. Введенные данные не распознаны.");
//             return true;
//         }



//         while (InputNum() == true) { }

//     }
// }


// ﻿// Задайте массив заполненный случайными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

// using System;
// class Program
// {
//     public static void Main()
//     {
//         int[] CreateArray(int size, int min, int max) //функция создания массива
//         {
//             int[] array = new int[size];
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max);
//             }
//             return array;
//         }

//         void PrintArray(int[] array) // функция печати массива
//         {
//             for (int i = 0; i < array.Length; i++)
//             {
//                 System.Console.Write(array[i] + " ");
//             }
//             System.Console.WriteLine();
//         }

//         int CountEvenNum(int[] array)
//         {
//             int count = 0;
//             for (int i = 0; i < array.Length; i++)
//             {
//                 if (array[i] % 2 == 0)
//                 {
//                     count++;
//                 }
//             }
//             return count;
//         }

//         System.Console.WriteLine($"Введите размер массива: ");
//         int size = Convert.ToInt32(Console.ReadLine());
//         int min = 100;
//         int max = 999;
//         int[] array = CreateArray(size,min,max);
//         System.Console.Write($"В массиве из целых 3-х значных чисел: "); 
//         PrintArray(array);
//         System.Console.Write($"четных чисел найдено в количестве {CountEvenNum(array)} штук.");

//     }
// }


// ﻿// Напишите программу, которая перевернёт одномерный массив 
// // (первый элемент станет последним, второй – предпоследним и т.д.)


// using System;
// class Program
// {
//     public static void Main()
//     {
//         int[] CreateArray(int size, int min, int max) //функция создания массива
//         {
//             int[] array = new int[size];
//             for (int i = 0; i < size; i++)
//             {
//                 array[i] = new Random().Next(min, max);
//             }
//             System.Console.WriteLine($"Массив создан.");
//             return array;
//         }

//         void PrintArray(int[] array) // функция печати массива
//         {
//             for (int i = 0; i < array.Length; i++)
//             {
//                 System.Console.Write(array[i] + " ");
//             }
//             System.Console.WriteLine();
//         }

//         int[] ReverseArray(int[] array)
//         {
//             for (int i = 0; i < array.Length / 2; i++)
//             {
//                 int temp = array[i];
//                 array[i] = array[array.Length - i - 1];
//                 array[array.Length - i - 1] = temp;
//             }
//             System.Console.WriteLine($"Массив перевернут.");
//             return array;
//         }

//         System.Console.WriteLine($"Введите размер массива: ");
//         int size = Convert.ToInt32(Console.ReadLine());
//         System.Console.WriteLine($"Введите минимальное значение элемента: ");
//         int min = Convert.ToInt32(Console.ReadLine());
//         System.Console.WriteLine($"Введите максимальное значение элемента: ");
//         int max = Convert.ToInt32(Console.ReadLine());
//         int[] array = CreateArray(size, min, max);
//         PrintArray(array);
//         ReverseArray(array);
//         PrintArray(array);
//     }
// }

