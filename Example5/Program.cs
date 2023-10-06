// Начинаем пользоваться случайными числами. Числа выпадают следующим образом первое минимальное число
// входит в промежуток а последнее будет на единичку меньше.
int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
Console.WriteLine("NumberA = " + numberA);
Console.WriteLine("NumberB = " + numberB);
int sum  = numberA + numberB;
Console.WriteLine("sum = " + sum);
