Console.WriteLine("Введите длинну массива");
int arrayLength = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите массив");
string[] array1 = CreateArray(arrayLength);
string[] array2 = new string[array1.Length];
CheckArray(array1, array2);







string[] CreateArray(int arrayLength)
{
    string[] array = new string[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] CheckArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
    return array2;
}