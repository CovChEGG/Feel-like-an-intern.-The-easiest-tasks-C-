/* Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
своих навыков.

Немного подумав они вспомнили, что не так давно на занятиях по математике
они проходили тему "свойства делимости целых чисел".На этом занятии преподаватель показывал
пример с использованием фактов делимости.
Пример заключался в следующем:
Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
так, что если одно число делится на другое, то эти числа попадают в разные руппы.
В результате этого разбиения получилось M групп, для N = 50, M = 6
N = 50
Группы получились такими:

Группа 1: 1
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 16 24 36 40
Группа 6: 32 48

Задача: найти M при заданном N.
И получить разбиение на группы*/
int EnterNumber()// функция ввода числа N
{
    Console.Write("Введите число :");
    int Number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");
    return Number;
}
int[] FillArrayTillN(int Number)// функция, которая заполняет исходный массив от 1 до N
{
    int[] Array = new int[Number];
    for(int i=1;i<=Number;i++)
    {
        Array[i-1] = i;
    }
    return Array;
}
void ShowArray(int[] Array, int count)// функция вводящая на экран элементы массива
{
    Console.Write("В группе №{0} находятся следующие элементы: ", count);
    for(int i =0; i<Array.Length;i++)
    {
        Console.Write(Array[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
}
int FoundNewI(int[] Array)// функция, которая находит длину следующей группы, и умножает на (-1) элементы, которые явялются кратными друг другу
{
    int key = 0;
    for(int i=0; i<Array.Length; i++)
    {
        for(int j=0; j<Array.Length-1; j++)
        {
            if(Array[j+1]%Array[i]==0 & Array[j+1]!=Array[i] & Array[i]>0 & Array[j+1]>0) Array[j+1]=Array[j+1]*(-1);
        }
    }
    for(int i=0;i<Array.Length;i++)
    {
        if(Array[i]>0) key++;
    }
    return key;
}
int[] CreateGroup(int[] Array, int NewKey)// функция создающая группу чисел, которые не делятся друг на друга
{
    int[] NewArray = new int[NewKey];
    int j = 0;
    for(int i = 0; i<Array.Length; i++)
    {
        if(Array[i]>0)
        {
            NewArray[j]=Array[i];
            j++;
        }
    }        
    return NewArray;
}
int[] CutExcess(int[] ArrayOld, int[] ArrayNew)// метод, который создает новый массив и заполняет только отрицательными значениями, а после этого умножает каждое еще раз на (-1)
{
    int NewLine = ArrayOld.Length - ArrayNew.Length;
    int[] ResultArray = new int[NewLine];
    int j=0;
    for(int i =0; i<ArrayOld.Length;i++)
    {
        if(ArrayOld[i]<0)
        {
            ResultArray[j]=ArrayOld[i]*(-1);
            j++;
        }
    }
    return ResultArray;
}
bool CheckingStop(int[] Array1, int[] Array2)// метод, позволяющий выйти из цикла вызова функций, он возвращает false только в том случае, если метод CutExcess вернет такой же массив, который был до его вызова
{
    if(Array1.Length-Array2.Length==0)
    return false;
    else return true;
}
int UserNumberN = EnterNumber();
int[] FreshArray = FillArrayTillN(UserNumberN);
int NewKey = FoundNewI(FreshArray);
int[] NextGroupNumbers = CreateGroup(FreshArray, NewKey);
bool STOP = CheckingStop(FreshArray,NextGroupNumbers);
int count =1;
ShowArray(NextGroupNumbers,count);
FreshArray = CutExcess(FreshArray, NextGroupNumbers);
while(STOP)
{
    NewKey=FoundNewI(FreshArray);
    NextGroupNumbers = CreateGroup(FreshArray, NewKey);
    STOP=CheckingStop(FreshArray,NextGroupNumbers);
    count++;
    ShowArray(NextGroupNumbers,count);
    FreshArray=CutExcess(FreshArray,NextGroupNumbers);
}
Console.WriteLine("В результате разбиения чисел на группы, в каждой из которых числа не делятся друг на друга, мы получили: {0} групп", count);