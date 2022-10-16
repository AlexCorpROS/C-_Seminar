/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumber(int n, int m)
{
  if (m >= n) return;
  Console.Write(m + ", ");
  PrintNumber(n, m + 1);
  
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

if (m < n)
{
    PrintNumber(n, m);
    Console.Write(n);
}
else
{
    PrintNumber(m, n);
    Console.Write(m);
}
