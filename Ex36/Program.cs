// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] GetAndFillArray(int arraySize, int userMin, int userMax)
{
    int[] newArray = new int[arraySize];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(userMin, userMax + 1);
        Console.Write($"[{newArray[i]}] ");
    }
    return newArray;
}

void SumArrayOddPosition(int[] userArray)
{
    int sum = 0;
    for (int j = 0; j < userArray.Length; j++)
    {
        if (j % 2 == 1)
        {
            sum += userArray[j];
        }
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях массива: {sum}");
}

int size = Prompt("Введите размер массива: ");
int max = Prompt("Введите максимальное значение элементов массива типа int: ");
int min = Prompt("Введите минимальное значение элементов массива типа int: ");
int[] array = GetAndFillArray(size, min, max);
Console.WriteLine();
SumArrayOddPosition(array);