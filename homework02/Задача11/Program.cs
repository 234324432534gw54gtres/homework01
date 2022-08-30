// Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа

Void Ex01()
{
int val = new Random().Next(10, 100);
int a = val / 10;
int b = val % 10;
Console.Writeline(val);

if (a > b)
{
    Console.Writeline(a);
}
else 
{
    Console.Writeline(b);
}
}
Ex01();