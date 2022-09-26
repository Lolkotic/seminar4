
/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число 1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 1; i <= userNumber2; i++)
    {
    result = userNumber1*result;
    }
Console.WriteLine($"Число {userNumber1} в степени {userNumber2} это {result}");

