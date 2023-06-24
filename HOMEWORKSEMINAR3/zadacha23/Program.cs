/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("введите любое число: ");
double number = Convert.ToDouble(Console.ReadLine());
int stepen = 3;

double number1 = number/number;

while (number1 <= number)
{
    number1 = number1 + 1;
    Console.WriteLine(Math.Pow(number1, stepen));
}
