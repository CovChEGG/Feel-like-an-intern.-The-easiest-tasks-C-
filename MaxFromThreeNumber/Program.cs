// Найти максимальное из трех чисел
int[] EnterArray()
{
    int[] ArrayOfNumbers = new int[3];
    for(int i=0; i<3;i++)
    {
        Console.Write("Введите {0} число : ", i+1);
        ArrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" ");
    }
    return ArrayOfNumbers;
}
/*int MaxItem(int number1, int number2, int number3)
{
    int count=0;
    int Max=number1;
    while(count<3)
    {
        if(Max>)
    }
}*/
int[] Array = EnterArray();
Console.WriteLine("Вы ввели следующие числа: {0} {1} {2}", Array[0], Array[1], Array[2]);
