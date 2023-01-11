// Найти кубы чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());

}

void cubeNumber(int number)
{
  for (int i = 1; i <= number; i++)
  {
    double cube = Math.Pow(i, 3);
    Console.WriteLine($"Куб числа {i} = " + cube);
  }
}

int number = GetValue("введите число: ");
Console.WriteLine();
cubeNumber(number);