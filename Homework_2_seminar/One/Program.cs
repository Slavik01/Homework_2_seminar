﻿// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//456 / 10 что бы получить 45 , потом Что надо сделать с 45,чтобы получить 5? 45 / 10 и получаем 4,5 и остаток 5 нужно вывести 

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10;
int b = a % 10;
Console.WriteLine (b);