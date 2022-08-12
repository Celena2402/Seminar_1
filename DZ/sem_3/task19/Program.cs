/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите число не меньше пятизначного: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number>99 && Number<1000)
{
    //int firstNumber = Number / 100;
    //int twoNumber = Number/10-firstNumber * 10;
    //Console.WriteLine($"В трехзначном числе {Number} второе число получается {twoNumber}.");
}
else
{
    Console.WriteLine($"Это число меньше пятизначного. Введите другое число!");
}
