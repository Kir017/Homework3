// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ

int GetValue(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

bool Palindrome(int val1)
{
  int val2 = 0;
  int inverseVal = val1;
  while (val1 > 0)
  {
    int remainder = val1 % 10;
    val1 = val1 / 10;
    val2 = val2 * 10 + remainder;
  }
  return inverseVal == val2;
}

int number = GetValue(" Введите пятизначное число: ");

Console.WriteLine();
if (Palindrome(number)) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} НЕ является палиндромом");