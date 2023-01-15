int a = 1;
int b = 425;
int c = 6;
int d = 732;
int e = 9;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = c;

Console.WriteLine($"max = {max}");