﻿Console.Clear();

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return (result);
}

int a1 = 15, a2 = 12, a3 = 13,
    b1 = 21, b2 = 23, b3 = 238,
    c1 = 39, c2 = 33, c3 = 3333;

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max3, max3); */

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)
);

Console.WriteLine(max);
