/* Урок 3. Базовые алгоритмы. Продолжение
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("введите любое пятизначное число: ");

int number1 (int numb )
{
    int result = numb;
    string i = Convert.ToString(numb);
    int leng = i.Length;
    //Console.WriteLine(leng);

 while (leng < 4 || leng > 6)
{
    Console.WriteLine("вы вели не верное число");
    break;
}
    if (i[0]== i[4] && i[1] == i[3])
    {
        Console.WriteLine("число палиндром");
    }
    else {
        Console.WriteLine("число не палиндром");
    }
    return result;   
}

int res = number1(int.Parse(Console.ReadLine()));
Console.WriteLine(res);


















/*
string i = Convert.ToString(res);
int leng = i.Length;
Console.WriteLine(leng);

if (leng <= 4)
{
    Console.WriteLine("вы вели число меньше пяти символов");
}
if (leng >= 6)
{
    Console.WriteLine("вы вели число больше 5 цифр");
}

if (i[0] == i[4] && i[1] == i[3])
{
    Console.WriteLine("+");
}
else{
    Console.WriteLine("-");
}
*/