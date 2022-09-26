/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = 0;
while(userNumber > 0)
{
    int result1 = userNumber % 10;
    result = result + result1;
    userNumber = userNumber/10;
}
Console.WriteLine($"Сумма цифр этого числа равна {result}");
