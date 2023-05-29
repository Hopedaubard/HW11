// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double[] GetAndFillArray(int arraySize, int userMin, int userMax)
{
    double[] newArray = new double[arraySize];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(userMin, userMax + 1);
        Console.Write($"[{newArray[i]}] ");
    }
    return newArray;
}

void FindDifferenceBetweenMaxMinArrayNum(double[] userArray)
{
    double maxValue = 0;
    for (int j = 0; j < userArray.Length; j++)
    {
        if (userArray[j] > maxValue)
        {
            maxValue = userArray[j];
        }
    }
    double minValue = maxValue;
    for (int j = 0; j < userArray.Length; j++)
    {
        if (userArray[j] < minValue)
        {
            minValue = userArray[j];
        }
    }
    double diff = maxValue - minValue;
    Console.WriteLine($"Разница между максимальным и минимальным значениями чисел массива: {diff}");
}

int size = Prompt("Введите размер массива: ");
int max = Prompt("Введите максимальное значение элементов массива типа int: ");
int min = Prompt("Введите минимальное значение элементов массива типа int: ");
double[] array = GetAndFillArray(size, min, max);
FindDifferenceBetweenMaxMinArrayNum(array);