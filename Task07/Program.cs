// 7. Показать числа от -N до N

Console.WriteLine("Введите целое число ");
string number = Console.ReadLine();
int num = int.Parse(number);
int numN = num * -1;
while (numN <= num)
{
    Console.WriteLine(numN);
    numN ++;
}
