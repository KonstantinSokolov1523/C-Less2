Console.Write("Введите номер задачи(1,2,3) ");
int N = Convert.ToInt32(Console.ReadLine());
switch (N)
{
case 1:
﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */
    Console.Write("Введите трехзначное число ");
    int A = Convert.ToInt32(Console.ReadLine());

    if(A > 99 & A < 1000)
    {
        int B = A % 100;
        Console.WriteLine(B/10);
    }
    else
    {
        Console.WriteLine("число не трехзначно");
    }
break;

case 2:
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
Console.Write("введите число ");
int C = Convert.ToInt32(Console.ReadLine());
int D = 0;
if (C > 99 && C < 1000)
{
    D = C % 10;
    Console.WriteLine(D);
}
else if(C / 1000 > 0 && C / 1000 < 10)
{
    D = (C%100)/10;
    Console.WriteLine(D);
}
else if (C / 1000 > 10 && C / 1000 < 100)
{
    C = (C%1000)/100;
    Console.WriteLine(C);
}
else if (C / 1000 > 100 && C / 1000 < 1000 )
{
    D = (C%10000)/1000;
    Console.WriteLine(D);
}
else
{
    Console.WriteLine("нет третьего числа");
}


break;
case 3:
/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
    Console.Write("Введите число ");
    int E = Convert.ToInt32(Console.ReadLine());

    if (E == 6 || E == 7)
    {
        Console.WriteLine("да");
    }
    else if(E > 1 && E < 6)
    {
        Console.WriteLine("нет");
    }
    else 
    {
        Console.WriteLine("Нет такого дня недели");
    }
break;
default: Console.WriteLine("Такой задачи нет");
break;

}