// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
Console.Write("Введите длинну массива = ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение = ");
int max = Convert.ToInt32(Console.ReadLine());
double[] CreateRandomArrayRndDouble(int length)
{
    double[] array = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        double num = random.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}
void PrintArrayDouble(double[] array)
{
    Console.Write("В представленном массиве - [");
    for (int i = 0; i < length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
double[] array = CreateRandomArrayRndDouble(length);
double MinArray(double[] array)
{
    double minArrey = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] < minArrey)
        {
            minArrey = array[i];
        }
    }
    return minArrey;
}
double MaxArray(double[] array)
{
    double maxArrey = array[0];
    for (int i = 0; i < length; i++)
    {
        if (array[i] > maxArrey)
        {
            maxArrey = array[i];
        }
    }
    return maxArrey;
}
double diffminmax = Math.Round (MaxArray(array) - MinArray(array), 1);
PrintArrayDouble(array);
Console.WriteLine($" Разница между максимальным и минимальным элементом в массиве = {diffminmax}");