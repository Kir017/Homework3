//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double GetDistance3D(double x1, double x2, double y1, double y2, double z1, double z2)
{
  return Math.Sqrt(Math.Pow(x1 - x2, 2)
                  + Math.Pow(y1 - y2, 2)
                  + Math.Pow(z1 - z2, 2));
}

double GetValue(string text)
{
  Console.Write(text);
  return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetValue("x1 = ");
double x2 = GetValue("x2 = ");
double y1 = GetValue("y1 = ");
double y2 = GetValue("y2 = ");
double z1 = GetValue("z1 = ");
double z2 = GetValue("z2 = ");

double distance = GetDistance3D(x1, x2, y1, y2, z1, z2);
Console.WriteLine();
Console.WriteLine($"Расстояние между координатами двух точек в 3D пространстве составляет {distance}");
