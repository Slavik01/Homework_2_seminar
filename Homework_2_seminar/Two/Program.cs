﻿// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());// в переменную число
string numberText = Convert.ToString(number); // спомощью метода ToString перевели число в строку,сколько чисел - столько элементов строк

while(number > 99 && number < 1000)
{
    if (numberText.Length <= 2)
    {
        Console.WriteLine("Вы ввели неверное число!");
    }
    else if (numberText.Length > 2) // спомощью Length выводим сколько символов в строке и если больше 2-ух
    {
    Console.WriteLine("Ваша последняя третья цифра: " + numberText[2]);// выводим эту цифру спомощью индекса элемента (благодаря Length)
    }
    else 
    {
    Console.WriteLine("Последней третьей цифры нет!"); // если число (преобразованное в строку ToString) 2 или меньше то выводим
    }
number ++;
}