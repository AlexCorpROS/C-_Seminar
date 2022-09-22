/*int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1);
    return result;
}

int getMaxDigitFromNumber(int number)
{
    int maxNumber = 0;
    while (number > 0)
    {
        int maxDigit = number % 10;
        if (maxNumber < maxDigit)
        {
            maxNumber = maxDigit;
        }
        number = number / 10;
    }
    return maxNumber;
}

int randomNumber = getRandomNumberFromRange(10,99);
Console.WriteLine($"Случайное значение {randomNumber}");
int maxDigit = getMaxDigitFromNumber(randomNumber);
Console.WriteLine($"Для числа {randomNumber} большая цифра {maxDigit}");

1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

int result = new int();
result = new Random().Next(100,1000);
Console.WriteLine(result);
int lastNumber = result % 10;
int firstNumber = result / 100;
Console.WriteLine($"{firstNumber}{lastNumber}");

2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("введите первое число");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int Number2 = Convert.ToInt32(Console.ReadLine());

int Result = Number1 % Number2;
if (Result == 0)
{
    Console.WriteLine("число кратно");
}
else 
{
    Console.WriteLine ($"число не кратно, остаток равен {Result}");
}

3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

Console.WriteLine("введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number % 7 == 0 && Number % 23 == 0)
{
   Console.WriteLine("число кратно 7 и 23"); 
}
else
{
    Console.WriteLine("число не кратно 7 и 23");
}

4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 
5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

*/

Console.WriteLine("введите первое число");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 == Number2 * Number2 )
{
    Console.WriteLine($"число {Number1} является квадратом {Number2}");
}
else if (Number2 == Number1 * Number1)
    {
        Console.WriteLine($"число {Number2} является квадратом {Number1}");
    }
else
{
    Console.WriteLine("ни одно число не является квадратом другого");
}

