// Выяснить является ли число чётным
int EnterNumber()
{
    Console.Write("Введите число :");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    return Number;
}
void CheckEven(int Number)
{
    int ResultOfCheck = Number%2;
    if(ResultOfCheck==1) Console.WriteLine("Число нечетное..");
    else Console.WriteLine("Число четное");
}
int UserNumber = EnterNumber();
CheckEven(UserNumber);