// Задайте массив. Напишите программу, которая выводит
//индексы всех элементов, равных заданному числу в массиве.
int GetNumber(string name)
{
    Console.WriteLine("Введите число " + name);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(4,6);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void GetIndex(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
            Console.Write(i + " ");
    }
}
int[] massiv = new int[12];
int number = GetNumber("");
FillArray(massiv);
PrintArray(massiv);
GetIndex(massiv, number);