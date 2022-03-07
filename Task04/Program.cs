// 4. Найти максимальное из трех чисел

int numA = new Random().Next(1,100);
Console.WriteLine("Первое число = " + numA);
int numB = new Random().Next(1,100);
Console.WriteLine("Второе число = " + numB);
int numC = new Random().Next(1,100);
Console.WriteLine("Третье число = " + numC);
int max = numA;
if ( max < numB) max = numB;
else if ( max < numC ) max = numC;
Console.WriteLine( max + " = наибольшее число");