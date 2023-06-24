/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/* 
/*Расстояние между точками — это число, равное корню из суммы квадратов разностей координат точек или длине разности радиус-векторов точек.*/
 


decimal rr(decimal rrA)
{

decimal rezultat = rrA; 
decimal rrA = ax + ay + az;
Console.WriteLine("Введите координаты точки х: ");
decimal ax = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки y: ");
decimal ay = decimal.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки z: ");
decimal az = decimal.Parse(Console.ReadLine());

Console.WriteLine($"{rezultat}");

return rezultat;

}

string gg = rr(rrA);
Console.WriteLine(gg);