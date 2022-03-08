// 10. Показать вторую цифру трёхзначного числа

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int secondNum = num % 100 / 10;
Console.WriteLine("Второе число = " + secondNum);
