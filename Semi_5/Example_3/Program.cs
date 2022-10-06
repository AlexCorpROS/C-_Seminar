/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

/*
void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше нуля. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int getLengthBoolArray(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 2;
        count++;
    }
    return count;
}

bool[] getBoolArray(int number)
{
    int length = getLengthBoolArray(number);
    bool[] boolArray = new bool[length];
    for (int index = 0; index < length; index++)
    {
        boolArray[length - 1 - index] = number % 2 != 0;
        number /= 2;
    }
    return boolArray;
}

void printBoolArray(bool[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] ? "1" : "0");
    }
    Console.WriteLine();
}

int number = GetNumberFromUser("Введите число");
bool[] boolArray = getBoolArray(number);
printBoolArray(boolArray);
*/


/*
Console.Clear();
Console.WriteLine("Приветствую! Эта программа будет преобразовывать десятичное число в двоичное.");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
        Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
        userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");
*/


// Задача 42. Чит решение
// int value = 45;
// string binary = Convert.ToString(value, 2);

// Console.WriteLine(binary);

// Задача 42. Хорошее решение
/*
    Console.Write("Decimal: ");
    int decimalNumber = int.Parse(Console.ReadLine());

    int remainder;
    string result = string.Empty;
    while (decimalNumber > 0)
    {
        remainder = decimalNumber % 2;
        decimalNumber /= 2;
        result = remainder.ToString() + result;
    }
    Console.WriteLine("Binary:  {0}", result);
*/

Console.Write("Введите число N");
int number_N = Convert.ToInt32(Console.ReadLine());

void printArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length - 1)
        {
           Console.Write(","); 
        }
    }
    Console.WriteLine("]");
}

void FirstNFibonacciNumbers(int user_number)
{
    int[] ArrayFibinaciNum = new int[user_number];
    ArrayFibinaciNum[0] = 0;
    ArrayFibinaciNum[1] = 1;
    int Sum = 0;
    for (int i = 2; i < user_number; i++)
    {
        Sum += ArrayFibinaciNum[i-1];
        ArrayFibinaciNum[i] = Sum;
    }
    printArray(ArrayFibinaciNum);
}

FirstNFibonacciNumbers(number_N);