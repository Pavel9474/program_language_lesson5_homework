// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,5) + new Random().NextDouble();
    }
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(Math.Round(arr[i], 2) + " ");
    }
    Console.WriteLine();
}
double MaxMinDifference(double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > max)
        {
            max=arr[i];
        }
        else if (arr[i] < min)
        {
            min=arr[i];
        }
        dif = max - min;
    return Math.Round(dif, 2);
}
double[] massiv = new double[12];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Разница между максимальным и минимальным элементом равна: " + MaxMinDifference(massiv));