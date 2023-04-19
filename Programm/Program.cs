int GetLength()
{
    Console.Write("Введите количество значений массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

string[] FillArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}-ое значение: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int NewArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
            count++;
    }
    return count;
}

string[] FillNewArray(string[] array, int length)
{
    int counter = 0;
    int len = NewArrayLength(array);
    string[] newArray = new string[len];
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
        {
            newArray[counter] = str;
            counter++;
        }
    }
    return newArray;
}
void PrintNewArray(string[] array, int length)
{
    if (length == 0)
        Console.WriteLine("Значения c тремя и менее символами в заданном массиве отсутствуют.");
    else
    {
        Console.Write("Новый массив значений c тремя и менее символами: [");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == length - 1)
                Console.WriteLine($"'{array[i]}'].");
            else
                Console.Write($"'{array[i]}', ");
        }
    }
}

try
{
    int length = GetLength();
    if (length > 0)
    {
        string[] array = new string[length];
        array = FillArray(length);
        int len = NewArrayLength(array);
        string[] newArray = new string[len];
        newArray = FillNewArray(array, length);
        PrintNewArray(newArray, len);
    }
    else
        Console.WriteLine("Количество значений должно быть больше нуля.");
}
catch
{
    Console.WriteLine("Ошибка! Введите количество значений в цифровом выражении.");
}