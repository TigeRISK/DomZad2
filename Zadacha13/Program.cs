﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string snum = Convert.ToString(num);
if (snum.Length >= 3)
{
    Console.WriteLine(snum[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}