/*
14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

int delenie1(int number, int number2)
{
    int result1=number % number2;
    return result1; 
}
int delenie2(int number, int number3)
{
       int result2=number % number3;
       return result2; 
}  

Console.WriteLine("Введите число");
int number=int.Parse(Console.ReadLine());

int number2=7;
int number3=23;
int digit1=delenie1(number, number2);
int digit2=delenie2(number, number3);

if (digit1=0 && digit2=0)
{
    Console.WriteLine($"Кратно");    
}
else
{
    Console.WriteLine($"Не кратно");
}