//int numberA = 15;
//int numberB = 78;
int numberA = new Random().Next(1, 100); // 1 2 3 ... 99
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);