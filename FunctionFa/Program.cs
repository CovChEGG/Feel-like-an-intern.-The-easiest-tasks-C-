// Написать программу вычисления значения функции y = f(a)
// Допустим f(a) : 3*a - 3 
int EnterNumber()
{
    Console.Write("Введите параметр a: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    return Number;
}
int FunctionFa(int a)
{
    int Y = 3*a - 3;
    return Y;
}
int a = EnterNumber();
int Y = FunctionFa(a);
Console.WriteLine("Функция выглядит следующим образом: y = 3*a - 3");
Console.WriteLine("Результатом функции Y=f({0}) будет : {1}",a, Y);
