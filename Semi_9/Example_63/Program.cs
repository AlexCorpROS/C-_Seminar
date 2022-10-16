/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

int n = InputNumbers("Введите n: ");
int count = 1;
PrintNumber(n, count);
Console.Write(n);

void PrintNumber(int n, int count)
{
  if (count >= n) return;
  Console.Write(count + ", ");
  PrintNumber(n, count + 1);
  
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

