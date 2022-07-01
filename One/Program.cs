// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

// Console.WriteLine("Введите число из отрезка от 10 до 99: ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next(10, 100);// до 100 по тому что 100 не включается , только левая сторона включается
Console.Write($"Случайное число - {number}"); // интерполяция - изменяет, форматирование строчки,а контентенации слияние,  $ и {}
int digitOne = number / 10; // из 56 получаем 5 / это деление
int digitTwo = number % 10; // получение остатка от целочисленного деления двух чисел благодаря %
Console.WriteLine(digitOne);
Console.WriteLine(digitTwo);

int max = Math.Max(digitOne,digitTwo); // ищет наибольшее число из 2 ух благодаря библиотете Math.Max
int min = Math.Min(digitOne,digitTwo); // ищет минимальное число из 2 ух благодаря библиотете Math.Min
Console.WriteLine($"Самое большое число - это {max}");
Console.WriteLine($"Самое большое число - это {min}");
