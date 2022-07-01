// Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.Write(number);
int digitOne = number / 100;
int digitThree = number % 10;
Console.WriteLine("Результат" + digitOne + digitThree);