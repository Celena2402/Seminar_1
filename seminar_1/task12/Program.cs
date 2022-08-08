/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток 
от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

int delenie(int number1, int number2)
{
    int result=number1 % number2;
    return result; 
}
Console.WriteLine("Введите число 1");
int number1=int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int number2=int.Parse(Console.ReadLine());

int digit=delenie(number1, number2);
if (digit>0)
{
    Console.WriteLine($"Не кратно, остаток {digit}");
}
else
{
    Console.WriteLine($"Кратно");
}