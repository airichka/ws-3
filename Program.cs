/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int xa, xb, ya, yb,za, zb; 
Console.Write($"Введите координату Х точки A: "); 
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Введите координату Y точки a: "); 
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Введите координату Z точки a: "); 
int.TryParse(Console.ReadLine()!, out za);
Console.Write($"Введите координату X точки B: "); 
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Введите координату Y точки B: "); 
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"Введите координату z точки B: "); 
int.TryParse(Console.ReadLine()!, out zb);

double ans = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
Console.Write($"расстояние между точками а И В = {Math.Round(ans, 2)}"); 