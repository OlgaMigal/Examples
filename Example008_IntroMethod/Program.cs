﻿// Найти максимум из 9 заданных чисел

int Max(int arg1, int arg2, int arg3)
{
    int result=arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int a1 = 5;
int b1 = 76;
int c1 = 92;
int a2 = 8;
int b2 = 11;
int c2 = 102;
int a3 = 547;
int b3 = 14;
int c3 = 1;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);
