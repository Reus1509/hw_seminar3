// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();

Console.Write("Введите координату X первой точки: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int Az = int.Parse(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int By = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int Bz = int.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);
Console.WriteLine($"A ({Ax},{Ay},{Az}); B ({Bx}, {By}, {Bz}) -> {result}");