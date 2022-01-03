// Даны два числа. Показать большее и меньшее число
int EnterNumber()
{
    Console.Write("Введите число :");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    return Number;
}
int MaxItem(int number1, int number2)
{
    if(number1>number2) return number1;
    else if(number1<number2) return number2;
    else 
    {
        Console.WriteLine("Два числа одинаковые");
        return number1;
    }
}
int FirstNumber = EnterNumber();
int SecondNumber = EnterNumber();
int Max = MaxItem(FirstNumber,SecondNumber);
Console.WriteLine("Из двух чисел максимальное - {0}", Max);
