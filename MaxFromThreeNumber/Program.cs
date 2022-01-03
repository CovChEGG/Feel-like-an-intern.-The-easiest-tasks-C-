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
int MaxItem(int[] Array)
{
    int i=0;
    int Max=Array[i];
    while(i<3)
    {
        if(Max<Array[i])
        {
            Max=Array[i];
        }
        i++;
    }
    return Max;
}
int[] Array = EnterArray();
Console.WriteLine("Вы ввели следующие числа: {0} {1} {2}", Array[0], Array[1], Array[2]);
int Result = MaxItem(Array);
Console.WriteLine("Максимальное число из введенных вами: {0}", Result);
