Console.Write("Введите число N = ");
int N = int.Parse(Console.ReadLine());

int a = 0;
double b = 0;
a = N%10;
b = N/10;

Console.WriteLine("деление с остатком" + a + " ");
Console.Write("деление целое" + b + " ");

