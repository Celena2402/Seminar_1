/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число не меньше пятизначного: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number>5)
{
    //int pramo=0;
    while (Number>0)
    {
        int pramo=Number/10;
        Console.WriteLine($"Прямое значение {pramo}");
    }
    //Console.WriteLine($"Прямое значение {pramo}");

    //int firstNumber = Number / 100;
    //int twoNumber = Number/10-firstNumber * 10;
    //Console.WriteLine($"В трехзначном числе {Number} второе число получается {twoNumber}.");
}
else
{
    Console.WriteLine($"Это число меньше пятизначного. Введите другое число!");
}
