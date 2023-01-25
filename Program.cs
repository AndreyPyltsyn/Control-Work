Console.WriteLine("Введите длинну массива");
int arrayLength = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите массив");
string[] array = CreateArray(arrayLength);








string[] CreateArray(int arrayLength)
{
    string[] array = new string[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine()!;
    }
    return array;
}