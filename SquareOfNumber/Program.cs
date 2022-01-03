// Вывести квадрат числа
int SquareOfNumber(int number)
{
    number=number*number;
    return number;
}
int UserNumber= Convert.ToInt32(Console.ReadLine());
int Result = SquareOfNumber(UserNumber);
Console.WriteLine("Ваше число в квадрате равно - {0}", Result);