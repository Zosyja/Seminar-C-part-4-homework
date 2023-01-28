// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillMas(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        int num = new Random().Next(-10, 11);
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
int SumMas(int[] arr)
{
    int sum = 0;
    for (int j=1; j<arr.Length; j++)
    {
        if (j%2>0) sum = sum + arr[j];
    }
    return sum;
}

int[] arr = new int[15];
FillMas(arr);
PrintMas(arr);
Console.Write("Сумма элементов, стоящих на нечетных позициях = ");
Console.WriteLine(SumMas(arr));
