/*  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53  */

int GetNumber(string message)
{
int resultNumber = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out resultNumber))
{
break;
}
else
{
Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!\n");
}
}
return resultNumber;
}

int pointAx = GetNumber("Введите координату X точки А: ");
int pointAy = GetNumber("Введите координату Y точки А: ");
int pointAz = GetNumber("Введите координату Z точки А: ");
int pointBx = GetNumber("Введите координату X точки B: ");
int pointBy = GetNumber("Введите координату Y точки B: ");
int pointBz = GetNumber("Введите координату Z точки B: ");

double DistanceBetweenPoints = Math.Sqrt(Math.Pow((pointBx - pointAx), 2) + Math.Pow((pointBy - pointAy), 2) + Math.Pow((pointBz - pointAz), 2));
DistanceBetweenPoints = Math.Round(DistanceBetweenPoints, 2);

Console.WriteLine($"Расстояние между точками А ({pointAx}, {pointAy}, {pointAz}) и В ({pointBx}, {pointBy}, {pointBz}) равно {DistanceBetweenPoints})");