// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях
Console.WriteLine("Hello, World!");
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,99);
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
int SumEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 0)
        sum = sum + arr[i] ;
    return sum;
}
int[] massiv = new int[3];
FillArray(massiv);
PrintArray(massiv);
Console.WriteLine("Сумма элементов на четных позициях равна: " + SumEvenPosition(massiv));