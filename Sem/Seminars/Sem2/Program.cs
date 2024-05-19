// void  NumToQuad(int num)
// {
//     System.Console.Write(num * num);
// }
// Console.WriteLine("Input number:  ");
// int a = Convert.ToInt32(Console.ReadLine());

// NumToQuad(a);


// int NumToQuadInt(int num)
// {
//     return num * num;
// }
// Console.WriteLine("Input number:  ");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = NumToQuadInt(a);              //А)
// System.Console.WriteLine(result);          //А)

// System.Console.WriteLine(NumToQuadInt(a));   //То же что и выше А)


// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// int DeletSecondDigit(int num)
// {
//   if(num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         return sot * 10 + ed;
//     }
//     else
//     {
//         System.Console.WriteLine("Input not three-digit number");
//         return 0;
//     }   
    
// }

// System.Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DeletSecondDigit(num)); 


// ТОЖЕ САМОЕ void ДОВСКИМ МЕТОДОМ


// void DeletSecondDigitVoid(int num)
// {
//   if(num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         System.Console.WriteLine(sot * 10 + ed);
//     }
//     else
//     {
//         System.Console.WriteLine("Input not three-digit number");
        
//     }   
    
// }

// System.Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine(DeletSecondDigit(num)); 
// DeletSecondDigitVoid(num);


// Архип Чижанов Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int SecondToThirdPower(int num)
// {
//   if(num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = num / 10 % 10;
//         int result = 1;
//         for(int i = 0; i < ed; i++) 
//         {
//         result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         System.Console.WriteLine("Input not three-digit number");
//         return 0;
        
//     }   
    
// }

// System.Console.WriteLine("Input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SecondToThirdPower(num)); 


// Архип Чижанов Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

void CheckIfDevides(int num1, int num2)
{
    if(num1 % num2 == 0)
    {
        System.Console.WriteLine($"{num1}, {num2} => yes");
    }
    else
    {
        System.Console.WriteLine($"{num1}, {num2} => no, {num1 % num2}");
    }

}

Console.Write("Input first number:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number:  ");
int num2 = Convert.ToInt32(Console.ReadLine());

CheckIfDevides(num1, num2);