﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(int start, int end)
// {
//     if (start==end)
//     {
//         return start.ToString();
//     }
//  return(PrintNumber(start+1, end)+" "+start);
// }
// Console.WriteLine(PrintNumber(1,n));
//________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int n, m, s=0;
// Console.Write("Введи значение от: ");
// n = Convert.ToInt16(Console.ReadLine());
// Console.Write("Введи значение до: ");
// m = Convert.ToInt16(Console.ReadLine());
// for (int i = n; i <= m; i++)
//    { if (i % 1 == 0) 
// s=s+i;    
 
// }
// Console.WriteLine(s);
//____________________________________________________________
// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.WriteLine("Введите число");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// int AkkermanFunc(int m, int n)
// 		{
// 			if(m == 0)
// 			{
// 				return n + 1;
// 			}
// 			if(m > 0 && n == 0)
// 			{
// 				return AkkermanFunc(m - 1, 1);
// 			}
// 			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
// 		}
		
// 		Console.WriteLine(AkkermanFunc(m,n));
	
