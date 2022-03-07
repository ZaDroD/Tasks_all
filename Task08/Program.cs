// 8. Показать четные числа от 1 до N

Console.WriteLine("Введите целое число N ");
string number = Console.ReadLine();
int num = int.Parse(number);
int count = 0;
while (count <= num)
{
    Console.WriteLine("Числа от 0 до N " + count );
    count = count + 2;

}