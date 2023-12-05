// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NToOne(int n, int count)
// {
//     if(count > n)
//     {
//        return;
//     } 
//     else
//     {
//         NToOne(n , count + 1);
//         System.Console.Write(count + " ");
//     }
// }
// System.Console.Write(" Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// NToOne(number, count);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumNumberMToN(int m, int n, int sum = 0)
// {
//     sum = sum + n;
//     if(n <= m)
//     {
//         System.Console.WriteLine($" Сумма чисел = {sum}");
//         return;
//     }
//     else
//     {
//         SumNumberMToN(m , n - 1, sum);
//     }
// }
// System.Console.WriteLine(" Введите число M: ");
// System.Console.WriteLine(" Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// SumNumberMToN(n , m); 

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Akerman( int n, int m)
// {
//     if(m == 0) return n + 1;
//     else if(n == 0)
//     {
//         return Akerman(m - 1, 1);
//     } 
//     else
//     {
//         return Akerman(m - 1, Akerman(m, n - 1));
//     } 
// }

// System.Console.WriteLine(" Введите неотрицательное число N: ");
// System.Console.WriteLine(" Введите неотрицательное число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Akerman(m , n);
