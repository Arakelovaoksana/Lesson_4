
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine()!);
int stepen = a;

for (int i = 1; i < b; i ++)
{
 stepen = stepen * a;
}
Console.WriteLine("А в степени В равно:" + stepen);