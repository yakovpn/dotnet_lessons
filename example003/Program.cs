//Console.Write("Введите первое число:");
//int a = int.Parse(Console.ReadLine());
int a = new Random().Next(1,100);
//Console.Write("Введите второе число:");
//int b = int.Parse(Console.ReadLine());
int b = new Random().Next(1,100);
int result = a + b;
Console.WriteLine ("Результат сложения двух чисел: " + result);