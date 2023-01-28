// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(100, 1000);
        arr[i] = num;
    }
}
void PrintMas(int[] arr)
{
    foreach (var el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}
int Even(int[] arr)
{
    int count = 0;
    for (int j=0; j<arr.Length; j++)
    {
        if (arr[j]%2==0) count++;
    }
    return count;
}

Console.Write("Введите размерность массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[k];
FillMas(arr);
PrintMas(arr);
Console.Write("Количество четных чисел в массиве = ");
Console.WriteLine(Even(arr));