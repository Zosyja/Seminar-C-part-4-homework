// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void FillMas(double[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000))/100;
    }
}
void PrintMas(double[] arr)
{
    foreach (var el in arr)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

double[] arr = new double[10];
FillMas(arr);
PrintMas(arr);

double max = arr[0];
double min = arr[0];

for (int j=1; j<arr.Length; j++)
{
    if (arr[j]>max) max = arr[j];
    if (arr[j]<min) min = arr[j];
}
double result = max-min;
Console.WriteLine("Максимальное значение = " + max);
Console.WriteLine("Минимальное значение = " + min);
Console.WriteLine("Разница между максимальным и минимальным значением = " + result);