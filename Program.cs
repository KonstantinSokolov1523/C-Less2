Console.Write("Введите номер задачи(1,2,3) ");
int N = convert.ToInt32(Console.ReadLine());
switch (N)
case 1:
{
﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */
Console.Write("Введите трехзначное число ")
int A = Convert.ToInt32(Console.ReadLine());

if(A/100 > 0 & A/100 < 10)
{
int B = A / 100;
Console.WriteLine(B%10);
}
else
{
Console.WriteLine("число не трехзначно");
}
}

Case 2:
{
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.WriteLine("Введите число");
int C = convert.ToInt32(ConsoleReadLine());

if(C / 1000 == 0)
{
Int D = C/100;
Console.WriteLine(D/10);
}
else if(C / 1000 > 0)
{
int D = C % 1000;
Console.WriteLine((D/100)/10);
}
else 
{
Console.Writeline("Третьей цифры нет!");
}
}

Case 3:
{
/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

int E = convert.ToInt32(Console.ReadLine());

if (E == 6 & E == 7)
{
Console.writeLine("да");
}
else if(E < 6 & E > 1)
{
Console.WriteLine("нет");
}
else 
{
Console.WriteLine("Нет такого дня недели");
}
}
default:
{
Console.WriteLine("Такой задачи нет")
}