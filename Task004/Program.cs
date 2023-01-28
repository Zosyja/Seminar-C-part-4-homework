// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200.
// Обновите список только при первом вхождении числа 20. 

void PrintMas(int[] arr)
{
    foreach (var el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}
void Find20(int[] arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]==20 && count==0)
        {
            arr[i]=200;
            count++;
        }
    }
}

int[] arr = {21, 53, 20, 56, 45, 20, 15, 43, 26, 20, 17};
PrintMas(arr);
Find20(arr);
PrintMas(arr);