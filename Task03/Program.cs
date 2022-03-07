// 3. По заданному номеру дня недели вывести его название

Console.WriteLine("Введите число от 1 до 7 :");
string num = Console.ReadLine();
if (num == "1") Console.Write("пн");
else if (num == "2") Console.Write("вт");
else if (num == "3") Console.Write("ср");
else if (num == "4") Console.Write("чт");
else if (num == "5") Console.Write("пт");
else if (num == "6") Console.Write("сб");
else if (num == "7") Console.Write("вс");
else Console.WriteLine("Сказал же от 1 до 7");