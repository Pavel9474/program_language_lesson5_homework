// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,5);
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
void PairMulti(int[] arr)
{
    for (int i = 0; i < arr.Length/2; i++)
    {
        int multi = arr[arr.Length-i-1]*arr[i];  
        Console.Write(multi + " ");
    }
}
int[] massiv = new int[12];
FillArray(massiv);
PrintArray(massiv);
PairMulti(massiv);
