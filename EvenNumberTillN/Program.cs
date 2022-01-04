// Показать четные числа от 1 до N
int EnterNumber()
{
    Console.Write("Введите число :");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    return Number;
}
int[] MakeArray(int Number)
{
    int[] Array = new int[Number];
    for(int i=1;i<=Number;i++)
    {
        Array[i-1]=i;
    }
    return Array;
}
void ShowArray(int[] Array)
{
    for(int i = 0; i<Array.Length; i++)
    {
        Console.Write(Array[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
}
int[] ArrayOfEven(int[] OldArray)
{
    int length = OldArray.Length/2;
    int[] NewArray=new int[OldArray.Length];
    int Indicator = 0;
    int j=0;
    for(int i=0;i<OldArray.Length;i++)
    {
        Indicator = OldArray[i]%2;
        if(Indicator==0)
        {
            NewArray[j] = OldArray[i];
            j++;
        }
    }
    return NewArray;
}
int UserNumber = EnterNumber();
int[] AllNumbersTillN = MakeArray(UserNumber);
int[] ArrayOfEvenNumber = ArrayOfEven(AllNumbersTillN);
ShowArray(ArrayOfEvenNumber);
