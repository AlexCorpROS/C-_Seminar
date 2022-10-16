// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int printRange(int N)
{
    if (N == 0)
    {
        return 0;
    }

    return N%10 + printRange(N / 10);
    
}

Console.WriteLine("ВВедите число N");
int userNumber = Convert.ToInt32(Console.ReadLine());
int summ=printRange(userNumber);
Console.Write($"{summ}");

/*
Console.WriteLine("Input number N");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(getSum(UserNumber));

int getSum (int N)
{
    if (N == 0)
    {
        return 0;
    }
    int digit = N%10;
    //getSum(N/10);
    //Console.Write($"N{N}, ");  
    //Console.Write($"digit {digit}, "); 
    return digit+getSum(N/10);
}
*/

