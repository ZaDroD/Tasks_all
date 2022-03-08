// 9. Показать последнюю цифру трёхзначного числа

int num = new Random().Next(100,1000);
Console.WriteLine("Рандомное трёхзначное число = " + num);
int lastnum = num % 10;
Console.WriteLine("Последняя цифра цисла = " + lastnum);
