// See https://aka.ms/new-console-template for more information
int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Ошибка ввода! Ожидается целое число. {userInformation}: ");
    }
    return result;
}

int userCoordinateX1 = getCoordinateFromUser("X1 = ");
int userCoordinateY1 = getCoordinateFromUser("Y1 = ");
int userCoordinateX2 = getCoordinateFromUser("X2 = ");
int userCoordinateY2 = getCoordinateFromUser("Y2 = ");

double findRangeBetweenTwoPoints(int coordinateX1, int coordinateY1, int coordinateX2, int coordinateY2)
{
    return Math.Sqrt(Math.Pow(coordinateX2 - coordinateX1, 2) + Math.Pow(coordinateY2 - coordinateY1, 2));
}

Console.WriteLine(findRangeBetweenTwoPoints(userCoordinateX1, userCoordinateY1, userCoordinateX2, userCoordinateY2));
