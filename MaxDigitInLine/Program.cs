// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

double GetRandomNumber()
{
    double Number = new Random().Next(10,100);
    return Number;
}
void GetDigit(double Number)
{
    double Digit1 = Number%10;
    double Digit2 = Math.Round((Number)/10);
    if(Digit1>Digit2)
    {
        Console.WriteLine(Digit1);
    }
    else if(Digit1<Digit2)
    {
        Console.WriteLine(Digit2);
    }
    else
    {
        Console.WriteLine("{0}, но обе цифры одинаковые.", Digit1);
    }
}
double RandomNumber = GetRandomNumber();
Console.Write("В числе {0} наибольшая цифра : ", RandomNumber);
GetDigit(RandomNumber);

