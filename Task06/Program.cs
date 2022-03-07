// 6. Выяснить является ли число чётным

int num = new Random().Next(1,100);
Console.WriteLine(num);
if (num % 2 == 0)
Console.WriteLine("Число " + num + " является чётным");
else Console.WriteLine("Число " + num + " не является чётным");
