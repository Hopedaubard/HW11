// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] GetAndFillArray(int arraySize)
{
    int[] newArray = new int[arraySize];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(100, 999);
        Console.Write($"[{newArray[i]}] ");
    }
    return newArray;
}

void CheckEvenNumArray(int[] userArray)
{
    int evenCount = 0;
    for (int j = 0; j < userArray.Length; j++)
    {
        if (userArray[j] % 2 == 0)
        {
            evenCount++;
        }
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
}

int num = Prompt("Введите размер массива: ");
int[] array = GetAndFillArray(num);
Console.WriteLine();
CheckEvenNumArray(array);



