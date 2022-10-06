/* See https://aka.ms/new-console-template for more information


char Input () 
{
    Console.WriteLine("Введите букву для проверки : ");
    char Test = Convert.ToChar(Console.ReadLine());
    string s = Convert.ToString(Test); 
    while(s.Length > 1)
    {
        Console.WriteLine ("Вы ввели больше одной буквы"); 
        Input();  
    }    
    Console.WriteLine (s);    
    return Test;
}
Console.WriteLine("input char : ");
char num = Input();
*/

/**Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
З
*/

/*
int[] userArray = new int[] { 6, 7, 19, 345, 3 };

int i = 0;
int userNumber = 0;
int count = userArray.Length;
int flag = 0;
Console.WriteLine("Введите число - ");
userNumber = Convert.ToInt32(Console.ReadLine());
for (i = 0; i < count; i++)
{
    if (userNumber == userArray[i])
    {
        Console.WriteLine($"Число {userNumber}  в массиве присутствует");
        flag=1;
        break;
    }
}
if(flag==0)
{
    Console.WriteLine($"Число {userNumber}  в массиве не присутствует");
}

*/

 